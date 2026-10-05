using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	public class AudioAssetRefCollection : IHotfixable
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x00008EDC File Offset: 0x000070DC
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x557D220", Offset = "0x557BE20", VA = "0x18557D220")]
		public bool CheckIfContains(AudioAsset asset)
		{
			return default(bool);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x557D430", Offset = "0x557C030", VA = "0x18557D430")]
		public void Reset()
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x557D180", Offset = "0x557BD80", VA = "0x18557D180")]
		public void AddKey(string key)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x557D370", Offset = "0x557BF70", VA = "0x18557D370")]
		public void ExportKeys(List<string> keys)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x557D4B0", Offset = "0x557C0B0", VA = "0x18557D4B0")]
		public AudioAssetRefCollection()
		{
		}

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x10")]
		private string[] m_cachedKeys;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x18")]
		private object[] m_cachedAssets;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<string> m_keys;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate279 __Hotfix0_CheckIfContains;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Reset;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_AddKey;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate0 __Hotfix0_ExportKeys;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
