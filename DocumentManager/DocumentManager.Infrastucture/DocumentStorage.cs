using System;
using System.Collections;
using System.Collections.Generic;


namespace DocumentManager.Infrastructure
{

	public class DocumentStorage : IDisposable
	{
		public void Dispose () { }

		public IEnumerable ImagesFor (
				string _ )
		{
			return new List<object>();
		}
	}

}