using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	internal class FileBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x060023B3 RID: 9139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x4BD5230", Offset = "0x4BD3E30", VA = "0x184BD5230", Slot = "4")]
		public ResourceSet GrovelForResourceSet(System.Globalization.CultureInfo culture, System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x4BD5170", Offset = "0x4BD3D70", VA = "0x184BD5170")]
		private string FindResourceFile(System.Globalization.CultureInfo culture, string fileName)
		{
			return null;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x4BD4D60", Offset = "0x4BD3960", VA = "0x184BD4D60")]
		private ResourceSet CreateResourceSet(string file)
		{
			return null;
		}

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x10")]
		private ResourceManager.ResourceManagerMediator _mediator;
	}
}
