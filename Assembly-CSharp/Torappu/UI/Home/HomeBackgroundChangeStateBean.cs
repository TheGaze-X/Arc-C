using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B5A RID: 19290
	[Token(Token = "0x2004B5A")]
	public class HomeBackgroundChangeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D0BA RID: 118970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0BA")]
		[Address(RVA = "0x1667A50", Offset = "0x1666650", VA = "0x181667A50")]
		public void LoadData(bool sortByAscend, string routedHomeBkgId)
		{
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D0BB")]
		[Address(RVA = "0x16682E0", Offset = "0x1666EE0", VA = "0x1816682E0")]
		private string _GetCurUsingBkgId()
		{
			return null;
		}

		// Token: 0x0601D0BC RID: 118972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0BC")]
		[Address(RVA = "0x1668420", Offset = "0x1667020", VA = "0x181668420")]
		private void _ResetItemModels(bool sortByAscend)
		{
		}

		// Token: 0x0601D0BD RID: 118973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0BD")]
		[Address(RVA = "0x1667D10", Offset = "0x1666910", VA = "0x181667D10")]
		public void ResortList(bool ascend)
		{
		}

		// Token: 0x0601D0BE RID: 118974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0BE")]
		[Address(RVA = "0x1667E90", Offset = "0x1666A90", VA = "0x181667E90")]
		public void SelectBg(string bgId)
		{
		}

		// Token: 0x0601D0BF RID: 118975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0BF")]
		[Address(RVA = "0x16679A0", Offset = "0x16665A0", VA = "0x1816679A0")]
		public void ChangeHideState()
		{
		}

		// Token: 0x0601D0C0 RID: 118976 RVA: 0x000AA1A8 File Offset: 0x000A83A8
		[Token(Token = "0x601D0C0")]
		[Address(RVA = "0x1668070", Offset = "0x1666C70", VA = "0x181668070")]
		private static int _CompareUpdateTimeAscend(HomeBackgroundItemModel left, HomeBackgroundItemModel right)
		{
			return 0;
		}

		// Token: 0x0601D0C1 RID: 118977 RVA: 0x000AA1C0 File Offset: 0x000A83C0
		[Token(Token = "0x601D0C1")]
		[Address(RVA = "0x1668170", Offset = "0x1666D70", VA = "0x181668170")]
		private static int _CompareUpdateTimeDescend(HomeBackgroundItemModel left, HomeBackgroundItemModel right)
		{
			return 0;
		}

		// Token: 0x0601D0C2 RID: 118978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0C2")]
		[Address(RVA = "0x1668270", Offset = "0x1666E70", VA = "0x181668270")]
		private void _ConsumeNew(string bgId)
		{
		}

		// Token: 0x0601D0C3 RID: 118979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0C3")]
		[Address(RVA = "0x1667C70", Offset = "0x1666870", VA = "0x181667C70")]
		public void OnPlayerDataChange(bool sortByAscend)
		{
		}

		// Token: 0x0601D0C4 RID: 118980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0C4")]
		[Address(RVA = "0x16688C0", Offset = "0x16674C0", VA = "0x1816688C0")]
		public HomeBackgroundChangeStateBean()
		{
		}

		// Token: 0x0402618A RID: 156042
		[Token(Token = "0x402618A")]
		[FieldOffset(Offset = "0x10")]
		public HomeBackgroundChangeViewProperty bgChangeProperty;

		// Token: 0x0402618B RID: 156043
		[Token(Token = "0x402618B")]
		[FieldOffset(Offset = "0x18")]
		public string presetInstId;

		// Token: 0x0402618C RID: 156044
		[Token(Token = "0x402618C")]
		[FieldOffset(Offset = "0x20")]
		public bool canChangePos;

		// Token: 0x0402618D RID: 156045
		[Token(Token = "0x402618D")]
		[FieldOffset(Offset = "0x28")]
		private string m_curSelectBackgroundId;

		// Token: 0x0402618E RID: 156046
		[Token(Token = "0x402618E")]
		[FieldOffset(Offset = "0x30")]
		private int m_routedSequenceNum;

		// Token: 0x0402618F RID: 156047
		[Token(Token = "0x402618F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026190 RID: 156048
		[Token(Token = "0x4026190")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetCurUsingBkgId;

		// Token: 0x04026191 RID: 156049
		[Token(Token = "0x4026191")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetItemModels;

		// Token: 0x04026192 RID: 156050
		[Token(Token = "0x4026192")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResortList;

		// Token: 0x04026193 RID: 156051
		[Token(Token = "0x4026193")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectBg;

		// Token: 0x04026194 RID: 156052
		[Token(Token = "0x4026194")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeHideState;

		// Token: 0x04026195 RID: 156053
		[Token(Token = "0x4026195")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CompareUpdateTimeAscend;

		// Token: 0x04026196 RID: 156054
		[Token(Token = "0x4026196")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CompareUpdateTimeDescend;

		// Token: 0x04026197 RID: 156055
		[Token(Token = "0x4026197")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ConsumeNew;

		// Token: 0x04026198 RID: 156056
		[Token(Token = "0x4026198")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChange;

		// Token: 0x04026199 RID: 156057
		[Token(Token = "0x4026199")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B5B RID: 19291
		[Token(Token = "0x2004B5B")]
		public class RoutedHomeBkgParam : IHotfixable
		{
			// Token: 0x0601D0C5 RID: 118981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D0C5")]
			[Address(RVA = "0x167A820", Offset = "0x1679420", VA = "0x18167A820")]
			public RoutedHomeBkgParam()
			{
			}

			// Token: 0x0402619A RID: 156058
			[Token(Token = "0x402619A")]
			[FieldOffset(Offset = "0x10")]
			public string routedHomeBkgId;

			// Token: 0x0402619B RID: 156059
			[Token(Token = "0x402619B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
