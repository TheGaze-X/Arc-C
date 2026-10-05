using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032DA RID: 13018
	[Token(Token = "0x20032DA")]
	public class LegionUIBlastCardEffectHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014B2F RID: 84783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B2F")]
		[Address(RVA = "0xD19470", Offset = "0xD18070", VA = "0x180D19470")]
		public void PlayBlastEffect()
		{
		}

		// Token: 0x06014B30 RID: 84784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B30")]
		[Address(RVA = "0xD19530", Offset = "0xD18130", VA = "0x180D19530")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06014B31 RID: 84785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B31")]
		[Address(RVA = "0xD19710", Offset = "0xD18310", VA = "0x180D19710")]
		public LegionUIBlastCardEffectHolder()
		{
		}

		// Token: 0x04018931 RID: 100657
		[Token(Token = "0x4018931")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Effect")]
		private GameObject _effectToLoad;

		// Token: 0x04018932 RID: 100658
		[Token(Token = "0x4018932")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_effect;

		// Token: 0x04018933 RID: 100659
		[Token(Token = "0x4018933")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayBlastEffect;

		// Token: 0x04018934 RID: 100660
		[Token(Token = "0x4018934")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04018935 RID: 100661
		[Token(Token = "0x4018935")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
