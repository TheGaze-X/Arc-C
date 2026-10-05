using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200442D RID: 17453
	[Token(Token = "0x200442D")]
	public class SandboxV2SquadGroupModel : IHotfixable
	{
		// Token: 0x17003F2F RID: 16175
		// (get) Token: 0x0601AA7C RID: 109180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F2F")]
		public string topicId
		{
			[Token(Token = "0x601AA7C")]
			[Address(RVA = "0x13C7BA0", Offset = "0x13C67A0", VA = "0x1813C7BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x0601AA7D RID: 109181 RVA: 0x000A2B40 File Offset: 0x000A0D40
		[Token(Token = "0x17003F30")]
		public long timestamp
		{
			[Token(Token = "0x601AA7D")]
			[Address(RVA = "0x13C7B40", Offset = "0x13C6740", VA = "0x1813C7B40")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x0601AA7E RID: 109182 RVA: 0x000A2B58 File Offset: 0x000A0D58
		[Token(Token = "0x17003F31")]
		public bool showRepo
		{
			[Token(Token = "0x601AA7E")]
			[Address(RVA = "0x13C7A70", Offset = "0x13C6670", VA = "0x1813C7A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x0601AA7F RID: 109183 RVA: 0x000A2B70 File Offset: 0x000A0D70
		[Token(Token = "0x17003F32")]
		public bool showNaviPanel
		{
			[Token(Token = "0x601AA7F")]
			[Address(RVA = "0x13C7A10", Offset = "0x13C6610", VA = "0x1813C7A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003F33 RID: 16179
		// (get) Token: 0x0601AA80 RID: 109184 RVA: 0x000A2B88 File Offset: 0x000A0D88
		[Token(Token = "0x17003F33")]
		public int scrollSeqNum
		{
			[Token(Token = "0x601AA80")]
			[Address(RVA = "0x13C7860", Offset = "0x13C6460", VA = "0x1813C7860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F34 RID: 16180
		// (get) Token: 0x0601AA81 RID: 109185 RVA: 0x000A2BA0 File Offset: 0x000A0DA0
		[Token(Token = "0x17003F34")]
		public float scrollTweenVal
		{
			[Token(Token = "0x601AA81")]
			[Address(RVA = "0x13C78C0", Offset = "0x13C64C0", VA = "0x1813C78C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003F35 RID: 16181
		// (get) Token: 0x0601AA82 RID: 109186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F35")]
		public SandboxV2CharRepoModel repoModel
		{
			[Token(Token = "0x601AA82")]
			[Address(RVA = "0x13C7800", Offset = "0x13C6400", VA = "0x1813C7800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F36 RID: 16182
		// (get) Token: 0x0601AA83 RID: 109187 RVA: 0x000A2BB8 File Offset: 0x000A0DB8
		[Token(Token = "0x17003F36")]
		public SandboxV2SquadGroupModel.ViewType selectViewType
		{
			[Token(Token = "0x601AA83")]
			[Address(RVA = "0x13C79B0", Offset = "0x13C65B0", VA = "0x1813C79B0")]
			get
			{
				return SandboxV2SquadGroupModel.ViewType.NONE;
			}
		}

		// Token: 0x17003F37 RID: 16183
		// (get) Token: 0x0601AA84 RID: 109188 RVA: 0x000A2BD0 File Offset: 0x000A0DD0
		[Token(Token = "0x17003F37")]
		public int squadCount
		{
			[Token(Token = "0x601AA84")]
			[Address(RVA = "0x13C7AD0", Offset = "0x13C66D0", VA = "0x1813C7AD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x0601AA85 RID: 109189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F38")]
		public SandboxV2SquadModel selectSquadModel
		{
			[Token(Token = "0x601AA85")]
			[Address(RVA = "0x13C7920", Offset = "0x13C6520", VA = "0x1813C7920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x0601AA86 RID: 109190 RVA: 0x000A2BE8 File Offset: 0x000A0DE8
		[Token(Token = "0x17003F39")]
		public bool isMonthMode
		{
			[Token(Token = "0x601AA86")]
			[Address(RVA = "0x13C77A0", Offset = "0x13C63A0", VA = "0x1813C77A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601AA87 RID: 109191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AA87")]
		[Address(RVA = "0x13C6930", Offset = "0x13C5530", VA = "0x1813C6930")]
		public SandboxV2SquadModel GetSquadModel(int squadIdx)
		{
			return null;
		}

		// Token: 0x0601AA88 RID: 109192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AA88")]
		[Address(RVA = "0x13C68A0", Offset = "0x13C54A0", VA = "0x1813C68A0")]
		public SandboxV2CharFoodModel GetCharFood(int charInstId)
		{
			return null;
		}

		// Token: 0x0601AA89 RID: 109193 RVA: 0x000A2C00 File Offset: 0x000A0E00
		[Token(Token = "0x601AA89")]
		[Address(RVA = "0x13C6BF0", Offset = "0x13C57F0", VA = "0x1813C6BF0")]
		public bool IsSquadSelect(int squadIdx)
		{
			return default(bool);
		}

		// Token: 0x0601AA8A RID: 109194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA8A")]
		[Address(RVA = "0x13C6CF0", Offset = "0x13C58F0", VA = "0x1813C6CF0")]
		public void SelectRepo()
		{
		}

		// Token: 0x0601AA8B RID: 109195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA8B")]
		[Address(RVA = "0x13C6D70", Offset = "0x13C5970", VA = "0x1813C6D70")]
		public void SelectSquad(int squadIdx)
		{
		}

		// Token: 0x0601AA8C RID: 109196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA8C")]
		[Address(RVA = "0x13C69C0", Offset = "0x13C55C0", VA = "0x1813C69C0")]
		public void InitData(string topicId, bool showRepo, bool showNaviPanel, SandboxV2SquadPanelShowMode showMode)
		{
		}

		// Token: 0x0601AA8D RID: 109197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA8D")]
		[Address(RVA = "0x13C6C70", Offset = "0x13C5870", VA = "0x1813C6C70")]
		public void ScrollToPos(float scrollPos)
		{
		}

		// Token: 0x0601AA8E RID: 109198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA8E")]
		[Address(RVA = "0x13C6E90", Offset = "0x13C5A90", VA = "0x1813C6E90")]
		private void _InitCharRepo(bool showRepo)
		{
		}

		// Token: 0x0601AA8F RID: 109199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA8F")]
		[Address(RVA = "0x13C7080", Offset = "0x13C5C80", VA = "0x1813C7080")]
		private void _InitSquadList(string topicId, PlayerSandboxV2 playerSandbox)
		{
		}

		// Token: 0x0601AA90 RID: 109200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA90")]
		[Address(RVA = "0x13C7370", Offset = "0x13C5F70", VA = "0x1813C7370")]
		private void _UpdateCharFood(string topicId)
		{
		}

		// Token: 0x0601AA91 RID: 109201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA91")]
		[Address(RVA = "0x13C6E30", Offset = "0x13C5A30", VA = "0x1813C6E30")]
		public void UpdateFoodModel()
		{
		}

		// Token: 0x0601AA92 RID: 109202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA92")]
		[Address(RVA = "0x13C7690", Offset = "0x13C6290", VA = "0x1813C7690")]
		public SandboxV2SquadGroupModel()
		{
		}

		// Token: 0x04022069 RID: 139369
		[Token(Token = "0x4022069")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x0402206A RID: 139370
		[Token(Token = "0x402206A")]
		[FieldOffset(Offset = "0x18")]
		private SandboxV2SquadGroupModel.ViewType m_selectViewType;

		// Token: 0x0402206B RID: 139371
		[Token(Token = "0x402206B")]
		[FieldOffset(Offset = "0x1C")]
		private int m_selectSquadIdx;

		// Token: 0x0402206C RID: 139372
		[Token(Token = "0x402206C")]
		[FieldOffset(Offset = "0x20")]
		private List<SandboxV2SquadModel> m_squadModelList;

		// Token: 0x0402206D RID: 139373
		[Token(Token = "0x402206D")]
		[FieldOffset(Offset = "0x28")]
		private SandboxV2CharRepoModel m_repoModel;

		// Token: 0x0402206E RID: 139374
		[Token(Token = "0x402206E")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, SandboxV2CharFoodModel> m_charFoodDict;

		// Token: 0x0402206F RID: 139375
		[Token(Token = "0x402206F")]
		[FieldOffset(Offset = "0x38")]
		private bool m_showRepo;

		// Token: 0x04022070 RID: 139376
		[Token(Token = "0x4022070")]
		[FieldOffset(Offset = "0x39")]
		private bool m_showNaviPanel;

		// Token: 0x04022071 RID: 139377
		[Token(Token = "0x4022071")]
		[FieldOffset(Offset = "0x3C")]
		private int m_scrollSeqNum;

		// Token: 0x04022072 RID: 139378
		[Token(Token = "0x4022072")]
		[FieldOffset(Offset = "0x40")]
		private float m_scrollTweenVal;

		// Token: 0x04022073 RID: 139379
		[Token(Token = "0x4022073")]
		[FieldOffset(Offset = "0x44")]
		private SandboxV2SquadPanelShowMode m_showMode;

		// Token: 0x04022074 RID: 139380
		[Token(Token = "0x4022074")]
		[FieldOffset(Offset = "0x48")]
		private long m_timestamp;

		// Token: 0x04022075 RID: 139381
		[Token(Token = "0x4022075")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04022076 RID: 139382
		[Token(Token = "0x4022076")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_timestamp;

		// Token: 0x04022077 RID: 139383
		[Token(Token = "0x4022077")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showRepo;

		// Token: 0x04022078 RID: 139384
		[Token(Token = "0x4022078")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showNaviPanel;

		// Token: 0x04022079 RID: 139385
		[Token(Token = "0x4022079")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_scrollSeqNum;

		// Token: 0x0402207A RID: 139386
		[Token(Token = "0x402207A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_scrollTweenVal;

		// Token: 0x0402207B RID: 139387
		[Token(Token = "0x402207B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_repoModel;

		// Token: 0x0402207C RID: 139388
		[Token(Token = "0x402207C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectViewType;

		// Token: 0x0402207D RID: 139389
		[Token(Token = "0x402207D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_squadCount;

		// Token: 0x0402207E RID: 139390
		[Token(Token = "0x402207E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_selectSquadModel;

		// Token: 0x0402207F RID: 139391
		[Token(Token = "0x402207F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isMonthMode;

		// Token: 0x04022080 RID: 139392
		[Token(Token = "0x4022080")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSquadModel;

		// Token: 0x04022081 RID: 139393
		[Token(Token = "0x4022081")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCharFood;

		// Token: 0x04022082 RID: 139394
		[Token(Token = "0x4022082")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsSquadSelect;

		// Token: 0x04022083 RID: 139395
		[Token(Token = "0x4022083")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SelectRepo;

		// Token: 0x04022084 RID: 139396
		[Token(Token = "0x4022084")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SelectSquad;

		// Token: 0x04022085 RID: 139397
		[Token(Token = "0x4022085")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04022086 RID: 139398
		[Token(Token = "0x4022086")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ScrollToPos;

		// Token: 0x04022087 RID: 139399
		[Token(Token = "0x4022087")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitCharRepo;

		// Token: 0x04022088 RID: 139400
		[Token(Token = "0x4022088")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitSquadList;

		// Token: 0x04022089 RID: 139401
		[Token(Token = "0x4022089")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateCharFood;

		// Token: 0x0402208A RID: 139402
		[Token(Token = "0x402208A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UpdateFoodModel;

		// Token: 0x0402208B RID: 139403
		[Token(Token = "0x402208B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200442E RID: 17454
		[Token(Token = "0x200442E")]
		public enum ViewType
		{
			// Token: 0x0402208D RID: 139405
			[Token(Token = "0x402208D")]
			NONE,
			// Token: 0x0402208E RID: 139406
			[Token(Token = "0x402208E")]
			REPO,
			// Token: 0x0402208F RID: 139407
			[Token(Token = "0x402208F")]
			SQUAD
		}
	}
}
