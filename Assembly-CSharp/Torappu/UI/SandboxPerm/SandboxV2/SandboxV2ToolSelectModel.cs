using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004452 RID: 17490
	[Token(Token = "0x2004452")]
	public class SandboxV2ToolSelectModel : IHotfixable
	{
		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x0601AB9B RID: 109467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F71")]
		public string topicId
		{
			[Token(Token = "0x601AB9B")]
			[Address(RVA = "0x13E90C0", Offset = "0x13E7CC0", VA = "0x1813E90C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x0601AB9C RID: 109468 RVA: 0x000A3110 File Offset: 0x000A1310
		[Token(Token = "0x17003F72")]
		public bool isMultipleMode
		{
			[Token(Token = "0x601AB9C")]
			[Address(RVA = "0x13E8FA0", Offset = "0x13E7BA0", VA = "0x1813E8FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x0601AB9D RID: 109469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F73")]
		public List<SandboxV2SquadToolModel> displayList
		{
			[Token(Token = "0x601AB9D")]
			[Address(RVA = "0x13E8F40", Offset = "0x13E7B40", VA = "0x1813E8F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x0601AB9E RID: 109470 RVA: 0x000A3128 File Offset: 0x000A1328
		[Token(Token = "0x17003F74")]
		public int scrollSeqNum
		{
			[Token(Token = "0x601AB9E")]
			[Address(RVA = "0x13E9000", Offset = "0x13E7C00", VA = "0x1813E9000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0601AB9F RID: 109471 RVA: 0x000A3140 File Offset: 0x000A1340
		[Token(Token = "0x17003F75")]
		public int scrollTargetIdx
		{
			[Token(Token = "0x601AB9F")]
			[Address(RVA = "0x13E9060", Offset = "0x13E7C60", VA = "0x1813E9060")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601ABA0 RID: 109472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA0")]
		[Address(RVA = "0x13E8710", Offset = "0x13E7310", VA = "0x1813E8710")]
		private void _ScrollToIdx(int targetIdx)
		{
		}

		// Token: 0x0601ABA1 RID: 109473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ABA1")]
		[Address(RVA = "0x13E7A60", Offset = "0x13E6660", VA = "0x1813E7A60")]
		public SandboxV2SquadToolModel FindFocusToolModel()
		{
			return null;
		}

		// Token: 0x0601ABA2 RID: 109474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ABA2")]
		[Address(RVA = "0x13E7B80", Offset = "0x13E6780", VA = "0x1813E7B80")]
		public List<string> GenSelectToolList()
		{
			return null;
		}

		// Token: 0x0601ABA3 RID: 109475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA3")]
		[Address(RVA = "0x13E7CB0", Offset = "0x13E68B0", VA = "0x1813E7CB0")]
		public void LoadData(SandboxV2ToolSelectStateBean.Input input)
		{
		}

		// Token: 0x0601ABA4 RID: 109476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA4")]
		[Address(RVA = "0x13E8530", Offset = "0x13E7130", VA = "0x1813E8530")]
		private void _InitTotalToolList()
		{
		}

		// Token: 0x0601ABA5 RID: 109477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA5")]
		[Address(RVA = "0x13E84D0", Offset = "0x13E70D0", VA = "0x1813E84D0")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x0601ABA6 RID: 109478 RVA: 0x000A3158 File Offset: 0x000A1358
		[Token(Token = "0x601ABA6")]
		[Address(RVA = "0x13E83C0", Offset = "0x13E6FC0", VA = "0x1813E83C0")]
		public bool TryGetSelectIdx(string toolId, out int selectIdx)
		{
			return default(bool);
		}

		// Token: 0x0601ABA7 RID: 109479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA7")]
		[Address(RVA = "0x13E79C0", Offset = "0x13E65C0", VA = "0x1813E79C0")]
		public void ClearSelect()
		{
		}

		// Token: 0x0601ABA8 RID: 109480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA8")]
		[Address(RVA = "0x13E8100", Offset = "0x13E6D00", VA = "0x1813E8100")]
		public void SelectTool(int selectIdx)
		{
		}

		// Token: 0x0601ABA9 RID: 109481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABA9")]
		[Address(RVA = "0x13E88B0", Offset = "0x13E74B0", VA = "0x1813E88B0")]
		private void _SelectToolInSingleMode(string toolId)
		{
		}

		// Token: 0x0601ABAA RID: 109482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABAA")]
		[Address(RVA = "0x13E8780", Offset = "0x13E7380", VA = "0x1813E8780")]
		private void _SelectToolInMultipleMode(string toolId)
		{
		}

		// Token: 0x0601ABAB RID: 109483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABAB")]
		[Address(RVA = "0x13E8B40", Offset = "0x13E7740", VA = "0x1813E8B40")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x0601ABAC RID: 109484 RVA: 0x000A3170 File Offset: 0x000A1370
		[Token(Token = "0x601ABAC")]
		[Address(RVA = "0x13E8A00", Offset = "0x13E7600", VA = "0x1813E8A00")]
		private int _SortByCustomRule(SandboxV2SquadToolModel x, SandboxV2SquadToolModel y)
		{
			return 0;
		}

		// Token: 0x0601ABAD RID: 109485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ABAD")]
		[Address(RVA = "0x13E8D90", Offset = "0x13E7990", VA = "0x1813E8D90")]
		public SandboxV2ToolSelectModel()
		{
		}

		// Token: 0x0402221F RID: 139807
		[Token(Token = "0x402221F")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x04022220 RID: 139808
		[Token(Token = "0x4022220")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isMultipleMode;

		// Token: 0x04022221 RID: 139809
		[Token(Token = "0x4022221")]
		[FieldOffset(Offset = "0x1C")]
		private int m_selectMaxCnt;

		// Token: 0x04022222 RID: 139810
		[Token(Token = "0x4022222")]
		[FieldOffset(Offset = "0x20")]
		private string m_focusToolId;

		// Token: 0x04022223 RID: 139811
		[Token(Token = "0x4022223")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_initSelectList;

		// Token: 0x04022224 RID: 139812
		[Token(Token = "0x4022224")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_selectToolList;

		// Token: 0x04022225 RID: 139813
		[Token(Token = "0x4022225")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_blackToolList;

		// Token: 0x04022226 RID: 139814
		[Token(Token = "0x4022226")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_totalToolIdList;

		// Token: 0x04022227 RID: 139815
		[Token(Token = "0x4022227")]
		[FieldOffset(Offset = "0x48")]
		private List<SandboxV2SquadToolModel> m_displayList;

		// Token: 0x04022228 RID: 139816
		[Token(Token = "0x4022228")]
		[FieldOffset(Offset = "0x50")]
		private int m_scrollSeqNum;

		// Token: 0x04022229 RID: 139817
		[Token(Token = "0x4022229")]
		[FieldOffset(Offset = "0x54")]
		private int m_scrollTargetIdx;

		// Token: 0x0402222A RID: 139818
		[Token(Token = "0x402222A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402222B RID: 139819
		[Token(Token = "0x402222B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMultipleMode;

		// Token: 0x0402222C RID: 139820
		[Token(Token = "0x402222C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_displayList;

		// Token: 0x0402222D RID: 139821
		[Token(Token = "0x402222D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_scrollSeqNum;

		// Token: 0x0402222E RID: 139822
		[Token(Token = "0x402222E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_scrollTargetIdx;

		// Token: 0x0402222F RID: 139823
		[Token(Token = "0x402222F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ScrollToIdx;

		// Token: 0x04022230 RID: 139824
		[Token(Token = "0x4022230")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FindFocusToolModel;

		// Token: 0x04022231 RID: 139825
		[Token(Token = "0x4022231")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenSelectToolList;

		// Token: 0x04022232 RID: 139826
		[Token(Token = "0x4022232")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04022233 RID: 139827
		[Token(Token = "0x4022233")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitTotalToolList;

		// Token: 0x04022234 RID: 139828
		[Token(Token = "0x4022234")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04022235 RID: 139829
		[Token(Token = "0x4022235")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetSelectIdx;

		// Token: 0x04022236 RID: 139830
		[Token(Token = "0x4022236")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ClearSelect;

		// Token: 0x04022237 RID: 139831
		[Token(Token = "0x4022237")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SelectTool;

		// Token: 0x04022238 RID: 139832
		[Token(Token = "0x4022238")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SelectToolInSingleMode;

		// Token: 0x04022239 RID: 139833
		[Token(Token = "0x4022239")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SelectToolInMultipleMode;

		// Token: 0x0402223A RID: 139834
		[Token(Token = "0x402223A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x0402223B RID: 139835
		[Token(Token = "0x402223B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SortByCustomRule;

		// Token: 0x0402223C RID: 139836
		[Token(Token = "0x402223C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
