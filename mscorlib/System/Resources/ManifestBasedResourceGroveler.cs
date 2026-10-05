using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	internal class ManifestBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x060023B8 RID: 9144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x4BD7380", Offset = "0x4BD5F80", VA = "0x184BD7380", Slot = "4")]
		[MethodImpl(8)]
		public ResourceSet GrovelForResourceSet(System.Globalization.CultureInfo culture, System.Collections.Generic.Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x4BD7E90", Offset = "0x4BD6A90", VA = "0x184BD7E90")]
		private System.Globalization.CultureInfo UltimateFallbackFixup(System.Globalization.CultureInfo lookForCulture)
		{
			return null;
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x4BD6DC0", Offset = "0x4BD59C0", VA = "0x184BD6DC0")]
		internal static System.Globalization.CultureInfo GetNeutralResourcesLanguage(System.Reflection.Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
		{
			return null;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x4BD6110", Offset = "0x4BD4D10", VA = "0x184BD6110")]
		internal ResourceSet CreateResourceSet(System.IO.Stream store, System.Reflection.Assembly assembly)
		{
			return null;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x4BD6BB0", Offset = "0x4BD57B0", VA = "0x184BD6BB0")]
		private System.IO.Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x4BD5C60", Offset = "0x4BD4860", VA = "0x184BD5C60")]
		[MethodImpl(8)]
		private System.IO.Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name)
		{
			return null;
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x4BD71A0", Offset = "0x4BD5DA0", VA = "0x184BD71A0")]
		[MethodImpl(8)]
		private RuntimeAssembly GetSatelliteAssembly(System.Globalization.CultureInfo lookForCulture, ref StackCrawlMark stackMark)
		{
			return null;
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x4BD5AD0", Offset = "0x4BD46D0", VA = "0x184BD5AD0")]
		private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
		{
			return default(bool);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x4BD7110", Offset = "0x4BD5D10", VA = "0x184BD7110")]
		private string GetSatelliteAssemblyName()
		{
			return null;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x4BD7AB0", Offset = "0x4BD66B0", VA = "0x184BD7AB0")]
		private void HandleSatelliteMissing()
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x4BD77A0", Offset = "0x4BD63A0", VA = "0x184BD77A0")]
		private void HandleResourceStreamMissing(string fileName)
		{
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00014388 File Offset: 0x00012588
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x4BD6D30", Offset = "0x4BD5930", VA = "0x184BD6D30")]
		private static bool GetNeutralResourcesLanguageAttribute(System.Reflection.Assembly assembly, ref string cultureName, ref short fallbackLocation)
		{
			return default(bool);
		}

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x10")]
		private ResourceManager.ResourceManagerMediator _mediator;
	}
}
