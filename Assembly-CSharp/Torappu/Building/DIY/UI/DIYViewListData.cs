using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019FF RID: 6655
	[Token(Token = "0x20019FF")]
	public class DIYViewListData : IHotfixable
	{
		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x0600A6E3 RID: 42723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700133C")]
		public List<DIYItemViewData> viewlistDatas
		{
			[Token(Token = "0x600A6E3")]
			[Address(RVA = "0x3220360", Offset = "0x321EF60", VA = "0x183220360")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x0600A6E4 RID: 42724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700133D")]
		public Dictionary<string, List<DIYItemViewData>> viewlistGroupDatas
		{
			[Token(Token = "0x600A6E4")]
			[Address(RVA = "0x32203C0", Offset = "0x321EFC0", VA = "0x1832203C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x0600A6E5 RID: 42725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700133E")]
		public Dictionary<string, DIYViewListData.FuncGroupData> funcGroupDatas
		{
			[Token(Token = "0x600A6E5")]
			[Address(RVA = "0x3220300", Offset = "0x321EF00", VA = "0x183220300")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x00040908 File Offset: 0x0003EB08
		[Token(Token = "0x600A6E6")]
		[Address(RVA = "0x321F940", Offset = "0x321E540", VA = "0x18321F940")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6E7")]
		[Address(RVA = "0x3220420", Offset = "0x321F020", VA = "0x183220420")]
		public static implicit operator DIYViewListData(List<DIYItemViewData> listDatas)
		{
			return null;
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6E8")]
		[Address(RVA = "0x321F4E0", Offset = "0x321E0E0", VA = "0x18321F4E0")]
		public Dictionary<string, List<DIYItemViewData>> AddDataToGroupDict(Dictionary<string, List<DIYItemViewData>> groupDatas)
		{
			return null;
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6E9")]
		[Address(RVA = "0x321FE10", Offset = "0x321EA10", VA = "0x18321FE10")]
		private Dictionary<string, List<DIYItemViewData>> _GetGroupDataFromDatas()
		{
			return null;
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6EA")]
		[Address(RVA = "0x321F9C0", Offset = "0x321E5C0", VA = "0x18321F9C0")]
		private Dictionary<string, DIYViewListData.FuncGroupData> _GetFuncDataFromDatas(List<DIYItemViewData> listDatas)
		{
			return null;
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6EB")]
		[Address(RVA = "0x32202A0", Offset = "0x321EEA0", VA = "0x1832202A0")]
		public DIYViewListData()
		{
		}

		// Token: 0x04009F0A RID: 40714
		[Token(Token = "0x4009F0A")]
		[FieldOffset(Offset = "0x10")]
		private List<DIYItemViewData> m_viewlistDatas;

		// Token: 0x04009F0B RID: 40715
		[Token(Token = "0x4009F0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewlistDatas;

		// Token: 0x04009F0C RID: 40716
		[Token(Token = "0x4009F0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_viewlistGroupDatas;

		// Token: 0x04009F0D RID: 40717
		[Token(Token = "0x4009F0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcGroupDatas;

		// Token: 0x04009F0E RID: 40718
		[Token(Token = "0x4009F0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04009F0F RID: 40719
		[Token(Token = "0x4009F0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_op_Implicit;

		// Token: 0x04009F10 RID: 40720
		[Token(Token = "0x4009F10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddDataToGroupDict;

		// Token: 0x04009F11 RID: 40721
		[Token(Token = "0x4009F11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetGroupDataFromDatas;

		// Token: 0x04009F12 RID: 40722
		[Token(Token = "0x4009F12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetFuncDataFromDatas;

		// Token: 0x04009F13 RID: 40723
		[Token(Token = "0x4009F13")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A00 RID: 6656
		[Token(Token = "0x2001A00")]
		public class FuncGroupData
		{
			// Token: 0x0600A6EC RID: 42732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FuncGroupData()
			{
			}

			// Token: 0x04009F14 RID: 40724
			[Token(Token = "0x4009F14")]
			[FieldOffset(Offset = "0x10")]
			public List<DIYItemViewData> viewlist;

			// Token: 0x04009F15 RID: 40725
			[Token(Token = "0x4009F15")]
			[FieldOffset(Offset = "0x18")]
			public string groupTitle;
		}
	}
}
