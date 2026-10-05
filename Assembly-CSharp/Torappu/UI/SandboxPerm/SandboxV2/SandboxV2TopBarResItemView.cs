using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200420C RID: 16908
	[Token(Token = "0x200420C")]
	public class SandboxV2TopBarResItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A167 RID: 106855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A167")]
		[Address(RVA = "0x12F8500", Offset = "0x12F7100", VA = "0x1812F8500")]
		public void Render(string topicId, UIItemViewModel viewModel)
		{
		}

		// Token: 0x0601A168 RID: 106856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A168")]
		[Address(RVA = "0x12F8870", Offset = "0x12F7470", VA = "0x1812F8870")]
		private string _FormatCount(int count, bool useSecResMax)
		{
			return null;
		}

		// Token: 0x0601A169 RID: 106857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A169")]
		[Address(RVA = "0x12F8960", Offset = "0x12F7560", VA = "0x1812F8960")]
		public SandboxV2TopBarResItemView()
		{
		}

		// Token: 0x04020E20 RID: 134688
		[Token(Token = "0x4020E20")]
		private const int SECOND_RES_MAX_COUNT = 999;

		// Token: 0x04020E21 RID: 134689
		[Token(Token = "0x4020E21")]
		private const int GOLD_RES_MAX_COUNT = 99999;

		// Token: 0x04020E22 RID: 134690
		[Token(Token = "0x4020E22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _resIcon;

		// Token: 0x04020E23 RID: 134691
		[Token(Token = "0x4020E23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _resName;

		// Token: 0x04020E24 RID: 134692
		[Token(Token = "0x4020E24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _resCount;

		// Token: 0x04020E25 RID: 134693
		[Token(Token = "0x4020E25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _useSecondResMax;

		// Token: 0x04020E26 RID: 134694
		[Token(Token = "0x4020E26")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020E27 RID: 134695
		[Token(Token = "0x4020E27")]
		[FieldOffset(Offset = "0x48")]
		private string m_topicId;

		// Token: 0x04020E28 RID: 134696
		[Token(Token = "0x4020E28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E29 RID: 134697
		[Token(Token = "0x4020E29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FormatCount;

		// Token: 0x04020E2A RID: 134698
		[Token(Token = "0x4020E2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
