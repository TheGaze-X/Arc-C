using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004214 RID: 16916
	[Token(Token = "0x2004214")]
	public class SandboxV2DungeonSphereChallengeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A18A RID: 106890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A18A")]
		[Address(RVA = "0x1301240", Offset = "0x12FFE40", VA = "0x181301240")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A18B RID: 106891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A18B")]
		[Address(RVA = "0x1301490", Offset = "0x1300090", VA = "0x181301490")]
		public SandboxV2DungeonSphereChallengeView()
		{
		}

		// Token: 0x04020E7C RID: 134780
		[Token(Token = "0x4020E7C")]
		private const string FORMAT_DEBUFF_TEXT = "+{0}%";

		// Token: 0x04020E7D RID: 134781
		[Token(Token = "0x4020E7D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _topicName;

		// Token: 0x04020E7E RID: 134782
		[Token(Token = "0x4020E7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlNewRecord;

		// Token: 0x04020E7F RID: 134783
		[Token(Token = "0x4020E7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDayDesc;

		// Token: 0x04020E80 RID: 134784
		[Token(Token = "0x4020E80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDebuffDesc;

		// Token: 0x04020E81 RID: 134785
		[Token(Token = "0x4020E81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDebuffHp;

		// Token: 0x04020E82 RID: 134786
		[Token(Token = "0x4020E82")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDebuffAtk;

		// Token: 0x04020E83 RID: 134787
		[Token(Token = "0x4020E83")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDebuffDef;

		// Token: 0x04020E84 RID: 134788
		[Token(Token = "0x4020E84")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDebuffContent;

		// Token: 0x04020E85 RID: 134789
		[Token(Token = "0x4020E85")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020E86 RID: 134790
		[Token(Token = "0x4020E86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E87 RID: 134791
		[Token(Token = "0x4020E87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
