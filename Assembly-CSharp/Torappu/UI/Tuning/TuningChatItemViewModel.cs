using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C85 RID: 15493
	[Token(Token = "0x2003C85")]
	public class TuningChatItemViewModel : IHotfixable
	{
		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x06018325 RID: 99109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039BA")]
		public string actId
		{
			[Token(Token = "0x6018325")]
			[Address(RVA = "0x10A8680", Offset = "0x10A7280", VA = "0x1810A8680")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x06018326 RID: 99110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039BB")]
		public string investId
		{
			[Token(Token = "0x6018326")]
			[Address(RVA = "0x10A8870", Offset = "0x10A7470", VA = "0x1810A8870")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x06018327 RID: 99111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039BC")]
		public string investAvatarId
		{
			[Token(Token = "0x6018327")]
			[Address(RVA = "0x10A87A0", Offset = "0x10A73A0", VA = "0x1810A87A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x06018328 RID: 99112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039BD")]
		public string groupId
		{
			[Token(Token = "0x6018328")]
			[Address(RVA = "0x10A86E0", Offset = "0x10A72E0", VA = "0x1810A86E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x06018329 RID: 99113 RVA: 0x00099A80 File Offset: 0x00097C80
		[Token(Token = "0x170039BE")]
		public Act29SideData.Act29SideInvestType investType
		{
			[Token(Token = "0x6018329")]
			[Address(RVA = "0x10A89F0", Offset = "0x10A75F0", VA = "0x1810A89F0")]
			get
			{
				return Act29SideData.Act29SideInvestType.MAJOR;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0601832A RID: 99114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039BF")]
		public string investNpcName
		{
			[Token(Token = "0x601832A")]
			[Address(RVA = "0x10A88D0", Offset = "0x10A74D0", VA = "0x1810A88D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0601832B RID: 99115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C0")]
		public string storyId
		{
			[Token(Token = "0x601832B")]
			[Address(RVA = "0x10A8AB0", Offset = "0x10A76B0", VA = "0x1810A8AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0601832C RID: 99116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C1")]
		public string npcPic
		{
			[Token(Token = "0x601832C")]
			[Address(RVA = "0x10A8A50", Offset = "0x10A7650", VA = "0x1810A8A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0601832D RID: 99117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C2")]
		public Act29SideData.Act29SideInvestResultData investSucResult
		{
			[Token(Token = "0x601832D")]
			[Address(RVA = "0x10A8990", Offset = "0x10A7590", VA = "0x1810A8990")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0601832E RID: 99118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C3")]
		public Act29SideData.Act29SideInvestResultData investFailResult
		{
			[Token(Token = "0x601832E")]
			[Address(RVA = "0x10A8810", Offset = "0x10A7410", VA = "0x1810A8810")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0601832F RID: 99119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039C4")]
		public Act29SideData.Act29SideInvestResultData investRareResult
		{
			[Token(Token = "0x601832F")]
			[Address(RVA = "0x10A8930", Offset = "0x10A7530", VA = "0x1810A8930")]
			get
			{
				return null;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x06018330 RID: 99120 RVA: 0x00099A98 File Offset: 0x00097C98
		[Token(Token = "0x170039C5")]
		public bool hasRecv
		{
			[Token(Token = "0x6018330")]
			[Address(RVA = "0x10A8740", Offset = "0x10A7340", VA = "0x1810A8740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06018331 RID: 99121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018331")]
		[Address(RVA = "0x10A8360", Offset = "0x10A6F60", VA = "0x1810A8360")]
		public void LoadData(string actId, Act29SideData.Act29SideInvestData investData, Dictionary<string, Act29SideData.Act29SideInvestResultData> resultDatas, Act29SideData.Act29SideConstData constData, [Optional] string slotId)
		{
		}

		// Token: 0x06018332 RID: 99122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018332")]
		[Address(RVA = "0x10A85B0", Offset = "0x10A71B0", VA = "0x1810A85B0")]
		public void RefreshData(bool hasReceived)
		{
		}

		// Token: 0x06018333 RID: 99123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018333")]
		[Address(RVA = "0x10A8620", Offset = "0x10A7220", VA = "0x1810A8620")]
		public TuningChatItemViewModel()
		{
		}

		// Token: 0x0401D759 RID: 120665
		[Token(Token = "0x401D759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0401D75A RID: 120666
		[Token(Token = "0x401D75A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_groupId;

		// Token: 0x0401D75B RID: 120667
		[Token(Token = "0x401D75B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string m_investId;

		// Token: 0x0401D75C RID: 120668
		[Token(Token = "0x401D75C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_investAvatarId;

		// Token: 0x0401D75D RID: 120669
		[Token(Token = "0x401D75D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Act29SideData.Act29SideInvestType m_investType;

		// Token: 0x0401D75E RID: 120670
		[Token(Token = "0x401D75E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_investNpcName;

		// Token: 0x0401D75F RID: 120671
		[Token(Token = "0x401D75F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string m_storyId;

		// Token: 0x0401D760 RID: 120672
		[Token(Token = "0x401D760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string m_npcPic;

		// Token: 0x0401D761 RID: 120673
		[Token(Token = "0x401D761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Act29SideData.Act29SideInvestResultData m_investSucResult;

		// Token: 0x0401D762 RID: 120674
		[Token(Token = "0x401D762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Act29SideData.Act29SideInvestResultData m_investFailResult;

		// Token: 0x0401D763 RID: 120675
		[Token(Token = "0x401D763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Act29SideData.Act29SideInvestResultData m_investRareResult;

		// Token: 0x0401D764 RID: 120676
		[Token(Token = "0x401D764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_hasRecv;

		// Token: 0x0401D765 RID: 120677
		[Token(Token = "0x401D765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_fakeNpcAvatarId;

		// Token: 0x0401D766 RID: 120678
		[Token(Token = "0x401D766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0401D767 RID: 120679
		[Token(Token = "0x401D767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_investId;

		// Token: 0x0401D768 RID: 120680
		[Token(Token = "0x401D768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_investAvatarId;

		// Token: 0x0401D769 RID: 120681
		[Token(Token = "0x401D769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x0401D76A RID: 120682
		[Token(Token = "0x401D76A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_investType;

		// Token: 0x0401D76B RID: 120683
		[Token(Token = "0x401D76B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_investNpcName;

		// Token: 0x0401D76C RID: 120684
		[Token(Token = "0x401D76C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_storyId;

		// Token: 0x0401D76D RID: 120685
		[Token(Token = "0x401D76D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_npcPic;

		// Token: 0x0401D76E RID: 120686
		[Token(Token = "0x401D76E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_investSucResult;

		// Token: 0x0401D76F RID: 120687
		[Token(Token = "0x401D76F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_investFailResult;

		// Token: 0x0401D770 RID: 120688
		[Token(Token = "0x401D770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_investRareResult;

		// Token: 0x0401D771 RID: 120689
		[Token(Token = "0x401D771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_hasRecv;

		// Token: 0x0401D772 RID: 120690
		[Token(Token = "0x401D772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D773 RID: 120691
		[Token(Token = "0x401D773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401D774 RID: 120692
		[Token(Token = "0x401D774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
