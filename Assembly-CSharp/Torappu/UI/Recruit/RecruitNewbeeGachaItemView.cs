using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004764 RID: 18276
	[Token(Token = "0x2004764")]
	public class RecruitNewbeeGachaItemView : RecruitGachaItemView
	{
		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x0601BACA RID: 113354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170041C2")]
		public override string gachaPoolId
		{
			[Token(Token = "0x601BACA")]
			[Address(RVA = "0x151B2B0", Offset = "0x1519EB0", VA = "0x18151B2B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601BACB RID: 113355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BACB")]
		[Address(RVA = "0x151AE70", Offset = "0x1519A70", VA = "0x18151AE70")]
		public new void OnRecruitOnce()
		{
		}

		// Token: 0x0601BACC RID: 113356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BACC")]
		[Address(RVA = "0x151AF00", Offset = "0x1519B00", VA = "0x18151AF00")]
		public new void OnRecruitTen()
		{
		}

		// Token: 0x0601BACD RID: 113357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BACD")]
		[Address(RVA = "0x151AB90", Offset = "0x1519790", VA = "0x18151AB90")]
		public void ApplyData(int index, NewbeeGachaPoolClientData data)
		{
		}

		// Token: 0x0601BACE RID: 113358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BACE")]
		[Address(RVA = "0x151AFE0", Offset = "0x1519BE0", VA = "0x18151AFE0", Slot = "5")]
		protected override void OnRefreshData()
		{
		}

		// Token: 0x0601BACF RID: 113359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BACF")]
		[Address(RVA = "0x151B240", Offset = "0x1519E40", VA = "0x18151B240")]
		public RecruitNewbeeGachaItemView()
		{
		}

		// Token: 0x0601BAD0 RID: 113360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BAD0")]
		[Address(RVA = "0x151B230", Offset = "0x1519E30", VA = "0x18151B230")]
		private string <>xLuaBaseProxy_get_gachaPoolId()
		{
			return null;
		}

		// Token: 0x0601BAD1 RID: 113361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BAD1")]
		[Address(RVA = "0x151B220", Offset = "0x1519E20", VA = "0x18151B220")]
		private void <>xLuaBaseProxy_OnRefreshData()
		{
		}

		// Token: 0x04023F10 RID: 147216
		[Token(Token = "0x4023F10")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x04023F11 RID: 147217
		[Token(Token = "0x4023F11")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private CanvasGroup _alphaGachaPart;

		// Token: 0x04023F12 RID: 147218
		[Token(Token = "0x4023F12")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private CanvasGroup _alphaTenGachaPart;

		// Token: 0x04023F13 RID: 147219
		[Token(Token = "0x4023F13")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private GameObject _lockedGachaIcon;

		// Token: 0x04023F14 RID: 147220
		[Token(Token = "0x4023F14")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private GameObject _lockedTenGachaIcon;

		// Token: 0x04023F15 RID: 147221
		[Token(Token = "0x4023F15")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private float _gachaAlpha;

		// Token: 0x04023F16 RID: 147222
		[Token(Token = "0x4023F16")]
		[FieldOffset(Offset = "0x250")]
		private NewbeeGachaPoolClientData m_data;

		// Token: 0x04023F17 RID: 147223
		[Token(Token = "0x4023F17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gachaPoolId;

		// Token: 0x04023F18 RID: 147224
		[Token(Token = "0x4023F18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecruitOnce;

		// Token: 0x04023F19 RID: 147225
		[Token(Token = "0x4023F19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRecruitTen;

		// Token: 0x04023F1A RID: 147226
		[Token(Token = "0x4023F1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04023F1B RID: 147227
		[Token(Token = "0x4023F1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023F1C RID: 147228
		[Token(Token = "0x4023F1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
