using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	public class ManifestResourceInfo
	{
		// Token: 0x06002479 RID: 9337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x4BD7FE0", Offset = "0x4BD6BE0", VA = "0x184BD7FE0")]
		public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
		{
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004B8")]
		public virtual Assembly ReferencedAssembly
		{
			[Token(Token = "0x600247A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170004B9")]
		public virtual string FileName
		{
			[Token(Token = "0x600247B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x00014718 File Offset: 0x00012918
		[Token(Token = "0x170004BA")]
		public virtual ResourceLocation ResourceLocation
		{
			[Token(Token = "0x600247C")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "6")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return (ResourceLocation)0;
			}
		}
	}
}
