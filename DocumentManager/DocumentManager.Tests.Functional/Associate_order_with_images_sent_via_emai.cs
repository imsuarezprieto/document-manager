using System;

using Infrastructure = DocumentManager.Infrastructure;

using Xunit;


namespace DocumentManager.Tests.Functional
{

	// ReSharper disable once InconsistentNaming
	public class Associate_order_with_images_sent_via_email
	{
		[Fact]
		public void An_email_without_order_id_in_its_subject_it_is_not_processed ()
		{
			const String orderId         = "";
			var          subject         = $"{orderId}";
			using var    emailSender     = new EmailSender();
			using var    documentStorage = new Infrastructure::DocumentStorage();

			emailSender.Send( subject );

			Assert.Empty(
					documentStorage.ImagesFor( orderId ) );
		}
	}

}