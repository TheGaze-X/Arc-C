using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public class ResourcesAPI
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E7")]
		internal static ResourcesAPI ActiveAPI
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x5952840", Offset = "0x5951440", VA = "0x185952840")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E8")]
		public static ResourcesAPI overrideAPI
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x59528F0", Offset = "0x59514F0", VA = "0x1859528F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected internal ResourcesAPI()
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x59525E0", Offset = "0x59511E0", VA = "0x1859525E0", Slot = "4")]
		protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance)
		{
			return null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x5952620", Offset = "0x5951220", VA = "0x185952620", Slot = "5")]
		protected internal virtual Shader FindShaderByName(string name)
		{
			return null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x5952730", Offset = "0x5951330", VA = "0x185952730", Slot = "6")]
		protected internal virtual Object Load(string path, Type systemTypeInstance)
		{
			return null;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x5952660", Offset = "0x5951260", VA = "0x185952660", Slot = "7")]
		protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance)
		{
			return null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x59526B0", Offset = "0x59512B0", VA = "0x1859526B0", Slot = "8")]
		protected internal virtual ResourceRequest LoadAsync(string path, Type systemTypeInstance)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x5952780", Offset = "0x5951380", VA = "0x185952780", Slot = "9")]
		protected internal virtual void UnloadAsset(Object assetToUnload)
		{
		}

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x0")]
		private static ResourcesAPI s_DefaultAPI;
	}
}
