using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DBC RID: 28092
	[Token(Token = "0x2006DBC")]
	public class ActVecBreakV2AchvBuffItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FF8 RID: 163832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FF8")]
		[Address(RVA = "0x23337C0", Offset = "0x23323C0", VA = "0x1823337C0")]
		public void Render(ActVecBreakV2AchvDefenseBuffModel buffModel)
		{
		}

		// Token: 0x06027FF9 RID: 163833 RVA: 0x000D04A0 File Offset: 0x000CE6A0
		[Token(Token = "0x6027FF9")]
		[Address(RVA = "0x23339E0", Offset = "0x23325E0", VA = "0x1823339E0")]
		private Color _GetColorBuff(ActVecBreakV2AchvDefenseBuffModel.BuffState buffState)
		{
			return default(Color);
		}

		// Token: 0x06027FFA RID: 163834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FFA")]
		[Address(RVA = "0x2333AB0", Offset = "0x23326B0", VA = "0x182333AB0")]
		public ActVecBreakV2AchvBuffItemView()
		{
		}

		// Token: 0x04038B51 RID: 232273
		[Token(Token = "0x4038B51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _closedPartGO;

		// Token: 0x04038B52 RID: 232274
		[Token(Token = "0x4038B52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _openPartGO;

		// Token: 0x04038B53 RID: 232275
		[Token(Token = "0x4038B53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _completePartGO;

		// Token: 0x04038B54 RID: 232276
		[Token(Token = "0x4038B54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBuffIcon;

		// Token: 0x04038B55 RID: 232277
		[Token(Token = "0x4038B55")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorBuffNormal;

		// Token: 0x04038B56 RID: 232278
		[Token(Token = "0x4038B56")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorBuffComplete;

		// Token: 0x04038B57 RID: 232279
		[Token(Token = "0x4038B57")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038B58 RID: 232280
		[Token(Token = "0x4038B58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038B59 RID: 232281
		[Token(Token = "0x4038B59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetColorBuff;

		// Token: 0x04038B5A RID: 232282
		[Token(Token = "0x4038B5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
