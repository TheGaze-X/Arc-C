using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BAC RID: 19372
	[Token(Token = "0x2004BAC")]
	public class HomeMailStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0601D206 RID: 119302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D206")]
		[Address(RVA = "0x169DB40", Offset = "0x169C740", VA = "0x18169DB40")]
		public MailItemViewModel GetMail(HomeMailIndex indexId)
		{
			return null;
		}

		// Token: 0x0601D207 RID: 119303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D207")]
		[Address(RVA = "0x169DE90", Offset = "0x169CA90", VA = "0x18169DE90")]
		public MailMetaInfo GetMeta(HomeMailIndex indexId)
		{
			return null;
		}

		// Token: 0x0601D208 RID: 119304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D208")]
		[Address(RVA = "0x169E060", Offset = "0x169CC60", VA = "0x18169E060")]
		public static UIItemViewModel ParseReceiveItemResponseToViewModel(MailGet mailGet)
		{
			return null;
		}

		// Token: 0x0601D209 RID: 119305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D209")]
		[Address(RVA = "0x169E140", Offset = "0x169CD40", VA = "0x18169E140")]
		public void ReceiveMail(HomeMailIndex mailIndex)
		{
		}

		// Token: 0x0601D20A RID: 119306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D20A")]
		[Address(RVA = "0x169DD20", Offset = "0x169C920", VA = "0x18169DD20")]
		public void GetMetaList(GetMetaInfoListResponse response)
		{
		}

		// Token: 0x0601D20B RID: 119307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D20B")]
		[Address(RVA = "0x169D6B0", Offset = "0x169C2B0", VA = "0x18169D6B0")]
		public void GetDataByIndex(int startIndex, int endIndex, ListMailBoxResponse response)
		{
		}

		// Token: 0x0601D20C RID: 119308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D20C")]
		[Address(RVA = "0x169E240", Offset = "0x169CE40", VA = "0x18169E240")]
		public HomeMailStateBean()
		{
		}

		// Token: 0x04026388 RID: 156552
		[Token(Token = "0x4026388")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public MailTitleViewProperty mailTitleViewProperty;

		// Token: 0x04026389 RID: 156553
		[Token(Token = "0x4026389")]
		[FieldOffset(Offset = "0x20")]
		public MailItemGroupViewProperty mailGroupProperty;

		// Token: 0x0402638A RID: 156554
		[Token(Token = "0x402638A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMail;

		// Token: 0x0402638B RID: 156555
		[Token(Token = "0x402638B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMeta;

		// Token: 0x0402638C RID: 156556
		[Token(Token = "0x402638C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ParseReceiveItemResponseToViewModel;

		// Token: 0x0402638D RID: 156557
		[Token(Token = "0x402638D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReceiveMail;

		// Token: 0x0402638E RID: 156558
		[Token(Token = "0x402638E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMetaList;

		// Token: 0x0402638F RID: 156559
		[Token(Token = "0x402638F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDataByIndex;

		// Token: 0x04026390 RID: 156560
		[Token(Token = "0x4026390")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
