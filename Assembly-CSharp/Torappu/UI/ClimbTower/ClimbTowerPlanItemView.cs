using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CED RID: 23789
	[Token(Token = "0x2005CED")]
	public class ClimbTowerPlanItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x06022711 RID: 141073 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022712 RID: 141074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005101")]
		public Action<bool> onPlanClick
		{
			[Token(Token = "0x6022711")]
			[Address(RVA = "0x1CD4B30", Offset = "0x1CD3730", VA = "0x181CD4B30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022712")]
			[Address(RVA = "0x1CD4B90", Offset = "0x1CD3790", VA = "0x181CD4B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022713 RID: 141075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022713")]
		[Address(RVA = "0x1CD48C0", Offset = "0x1CD34C0", VA = "0x181CD48C0")]
		public void Render(bool isFree)
		{
		}

		// Token: 0x06022714 RID: 141076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022714")]
		[Address(RVA = "0x1CD47B0", Offset = "0x1CD33B0", VA = "0x181CD47B0")]
		public void OnPlanClick()
		{
		}

		// Token: 0x06022715 RID: 141077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022715")]
		[Address(RVA = "0x1CD4AD0", Offset = "0x1CD36D0", VA = "0x181CD4AD0")]
		public ClimbTowerPlanItemView()
		{
		}

		// Token: 0x0402F573 RID: 193907
		[Token(Token = "0x402F573")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x0402F574 RID: 193908
		[Token(Token = "0x402F574")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402F575 RID: 193909
		[Token(Token = "0x402F575")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F576 RID: 193910
		[Token(Token = "0x402F576")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _logoPlan;

		// Token: 0x0402F577 RID: 193911
		[Token(Token = "0x402F577")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _logoAtlas;

		// Token: 0x0402F578 RID: 193912
		[Token(Token = "0x402F578")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _freeState;

		// Token: 0x0402F57A RID: 193914
		[Token(Token = "0x402F57A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onPlanClick;

		// Token: 0x0402F57B RID: 193915
		[Token(Token = "0x402F57B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onPlanClick;

		// Token: 0x0402F57C RID: 193916
		[Token(Token = "0x402F57C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F57D RID: 193917
		[Token(Token = "0x402F57D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPlanClick;

		// Token: 0x0402F57E RID: 193918
		[Token(Token = "0x402F57E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
