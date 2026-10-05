using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004369 RID: 17257
	[Token(Token = "0x2004369")]
	public class SandboxV2RacerInventoryViewModel : IHotfixable
	{
		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0601A7B9 RID: 108473 RVA: 0x000A1F58 File Offset: 0x000A0158
		[Token(Token = "0x17003EE5")]
		public bool isEmpty
		{
			[Token(Token = "0x601A7B9")]
			[Address(RVA = "0x1395050", Offset = "0x1393C50", VA = "0x181395050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A7BA RID: 108474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7BA")]
		[Address(RVA = "0x1394440", Offset = "0x1393040", VA = "0x181394440")]
		public void LoadData(SandboxV2RacerInventoryViewModel.Input input)
		{
		}

		// Token: 0x0601A7BB RID: 108475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7BB")]
		[Address(RVA = "0x1394680", Offset = "0x1393280", VA = "0x181394680")]
		public void RefreshData()
		{
		}

		// Token: 0x0601A7BC RID: 108476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7BC")]
		[Address(RVA = "0x13946F0", Offset = "0x13932F0", VA = "0x1813946F0")]
		public void RefreshInfo()
		{
		}

		// Token: 0x0601A7BD RID: 108477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7BD")]
		[Address(RVA = "0x1394A80", Offset = "0x1393680", VA = "0x181394A80")]
		private void _RefreshRacerBagData()
		{
		}

		// Token: 0x0601A7BE RID: 108478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7BE")]
		[Address(RVA = "0x1394F50", Offset = "0x1393B50", VA = "0x181394F50")]
		public SandboxV2RacerInventoryViewModel()
		{
		}

		// Token: 0x04021B33 RID: 138035
		[Token(Token = "0x4021B33")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, SandboxV2RacerModel> racerList;

		// Token: 0x04021B34 RID: 138036
		[Token(Token = "0x4021B34")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2RacerModel> itemModelList;

		// Token: 0x04021B35 RID: 138037
		[Token(Token = "0x4021B35")]
		[FieldOffset(Offset = "0x20")]
		public string selectInstId;

		// Token: 0x04021B36 RID: 138038
		[Token(Token = "0x4021B36")]
		[FieldOffset(Offset = "0x28")]
		public string topicId;

		// Token: 0x04021B37 RID: 138039
		[Token(Token = "0x4021B37")]
		[FieldOffset(Offset = "0x30")]
		public string bagName;

		// Token: 0x04021B38 RID: 138040
		[Token(Token = "0x4021B38")]
		[FieldOffset(Offset = "0x38")]
		public string emptyLeftDesc;

		// Token: 0x04021B39 RID: 138041
		[Token(Token = "0x4021B39")]
		[FieldOffset(Offset = "0x40")]
		public string emptyRightDesc;

		// Token: 0x04021B3A RID: 138042
		[Token(Token = "0x4021B3A")]
		[FieldOffset(Offset = "0x48")]
		public string tokenId;

		// Token: 0x04021B3B RID: 138043
		[Token(Token = "0x4021B3B")]
		[FieldOffset(Offset = "0x50")]
		public int tokenCount;

		// Token: 0x04021B3C RID: 138044
		[Token(Token = "0x4021B3C")]
		[FieldOffset(Offset = "0x54")]
		public int racerCount;

		// Token: 0x04021B3D RID: 138045
		[Token(Token = "0x4021B3D")]
		[FieldOffset(Offset = "0x58")]
		public int bagCapacity;

		// Token: 0x04021B3E RID: 138046
		[Token(Token = "0x4021B3E")]
		[FieldOffset(Offset = "0x60")]
		public string tempBagName;

		// Token: 0x04021B3F RID: 138047
		[Token(Token = "0x4021B3F")]
		[FieldOffset(Offset = "0x68")]
		public int tempRacerCount;

		// Token: 0x04021B40 RID: 138048
		[Token(Token = "0x4021B40")]
		[FieldOffset(Offset = "0x6C")]
		public float tempBagRatio;

		// Token: 0x04021B41 RID: 138049
		[Token(Token = "0x4021B41")]
		[FieldOffset(Offset = "0x70")]
		public bool showTempBagFullIcon;

		// Token: 0x04021B42 RID: 138050
		[Token(Token = "0x4021B42")]
		[FieldOffset(Offset = "0x78")]
		public string nodeId;

		// Token: 0x04021B43 RID: 138051
		[Token(Token = "0x4021B43")]
		[FieldOffset(Offset = "0x80")]
		public string stageId;

		// Token: 0x04021B44 RID: 138052
		[Token(Token = "0x4021B44")]
		[FieldOffset(Offset = "0x88")]
		public int apCost;

		// Token: 0x04021B45 RID: 138053
		[Token(Token = "0x4021B45")]
		[FieldOffset(Offset = "0x8C")]
		public SandboxV2RacerInfoPage.Type type;

		// Token: 0x04021B46 RID: 138054
		[Token(Token = "0x4021B46")]
		[FieldOffset(Offset = "0x90")]
		public int focusSequenceNum;

		// Token: 0x04021B47 RID: 138055
		[Token(Token = "0x4021B47")]
		[FieldOffset(Offset = "0x94")]
		public int learnTalentSequenceNum;

		// Token: 0x04021B48 RID: 138056
		[Token(Token = "0x4021B48")]
		[FieldOffset(Offset = "0x98")]
		private int m_tempBagCapacity;

		// Token: 0x04021B49 RID: 138057
		[Token(Token = "0x4021B49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04021B4A RID: 138058
		[Token(Token = "0x4021B4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021B4B RID: 138059
		[Token(Token = "0x4021B4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04021B4C RID: 138060
		[Token(Token = "0x4021B4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x04021B4D RID: 138061
		[Token(Token = "0x4021B4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshRacerBagData;

		// Token: 0x04021B4E RID: 138062
		[Token(Token = "0x4021B4E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200436A RID: 17258
		[Token(Token = "0x200436A")]
		public struct Input
		{
			// Token: 0x04021B4F RID: 138063
			[Token(Token = "0x4021B4F")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04021B50 RID: 138064
			[Token(Token = "0x4021B50")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2RacerInfoPage.Type type;

			// Token: 0x04021B51 RID: 138065
			[Token(Token = "0x4021B51")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x04021B52 RID: 138066
			[Token(Token = "0x4021B52")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x04021B53 RID: 138067
			[Token(Token = "0x4021B53")]
			[FieldOffset(Offset = "0x20")]
			public int apCost;
		}
	}
}
