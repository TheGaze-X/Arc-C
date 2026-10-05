using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005531 RID: 21809
	[Token(Token = "0x2005531")]
	public class RoguelikeSquadStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x0602012C RID: 131372 RVA: 0x000B47C8 File Offset: 0x000B29C8
		// (set) Token: 0x0602012D RID: 131373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B37")]
		public PlayerRoguelikeZoneType curZoneType
		{
			[Token(Token = "0x602012C")]
			[Address(RVA = "0x1A3CAC0", Offset = "0x1A3B6C0", VA = "0x181A3CAC0")]
			[CompilerGenerated]
			get
			{
				return PlayerRoguelikeZoneType.NORMAL;
			}
			[Token(Token = "0x602012D")]
			[Address(RVA = "0x1A3CBE0", Offset = "0x1A3B7E0", VA = "0x181A3CBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x0602012E RID: 131374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602012F RID: 131375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B38")]
		public string topicId
		{
			[Token(Token = "0x602012E")]
			[Address(RVA = "0x1A3CB20", Offset = "0x1A3B720", VA = "0x181A3CB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602012F")]
			[Address(RVA = "0x1A3CC50", Offset = "0x1A3B850", VA = "0x181A3CC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x06020130 RID: 131376 RVA: 0x000B47E0 File Offset: 0x000B29E0
		[Token(Token = "0x17004B39")]
		public int troopCount
		{
			[Token(Token = "0x6020130")]
			[Address(RVA = "0x1A3CB80", Offset = "0x1A3B780", VA = "0x181A3CB80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06020131 RID: 131377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020131")]
		[Address(RVA = "0x1A3B0A0", Offset = "0x1A39CA0", VA = "0x181A3B0A0")]
		public void AttachPluginContexts(List<IRoguelikeCharCardViewPluginContext> pluginContexts)
		{
		}

		// Token: 0x06020132 RID: 131378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020132")]
		[Address(RVA = "0x1A3B250", Offset = "0x1A39E50", VA = "0x181A3B250")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x06020133 RID: 131379 RVA: 0x000B47F8 File Offset: 0x000B29F8
		[Token(Token = "0x6020133")]
		[Address(RVA = "0x1A3B180", Offset = "0x1A39D80", VA = "0x181A3B180")]
		public int GetCurCapacity()
		{
			return 0;
		}

		// Token: 0x06020134 RID: 131380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020134")]
		[Address(RVA = "0x1A3B7D0", Offset = "0x1A3A3D0", VA = "0x181A3B7D0")]
		public Dictionary<int, int> LoadSquadSkillPref()
		{
			return null;
		}

		// Token: 0x06020135 RID: 131381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020135")]
		[Address(RVA = "0x1A3B690", Offset = "0x1A3A290", VA = "0x181A3B690")]
		public Dictionary<int, int> LoadSquadSkillCount()
		{
			return null;
		}

		// Token: 0x06020136 RID: 131382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020136")]
		[Address(RVA = "0x1A3B520", Offset = "0x1A3A120", VA = "0x181A3B520")]
		public Dictionary<int, string> LoadSquadBranchPref()
		{
			return null;
		}

		// Token: 0x06020137 RID: 131383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020137")]
		[Address(RVA = "0x1A3B120", Offset = "0x1A39D20", VA = "0x181A3B120")]
		public void ConfirmSquad()
		{
		}

		// Token: 0x06020138 RID: 131384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020138")]
		[Address(RVA = "0x1A3C530", Offset = "0x1A3B130", VA = "0x181A3C530")]
		private void _UniformSquad()
		{
		}

		// Token: 0x06020139 RID: 131385 RVA: 0x000B4810 File Offset: 0x000B2A10
		[Token(Token = "0x6020139")]
		[Address(RVA = "0x1A3C2C0", Offset = "0x1A3AEC0", VA = "0x181A3C2C0")]
		private int _GetSquadTroopCount()
		{
			return 0;
		}

		// Token: 0x0602013A RID: 131386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602013A")]
		[Address(RVA = "0x1A3B910", Offset = "0x1A3A510", VA = "0x181A3B910")]
		public void SaveLocalCache()
		{
		}

		// Token: 0x0602013B RID: 131387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602013B")]
		[Address(RVA = "0x1A3B970", Offset = "0x1A3A570", VA = "0x181A3B970")]
		public void TryAddTroopToSquad()
		{
		}

		// Token: 0x0602013C RID: 131388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602013C")]
		[Address(RVA = "0x1A3BF80", Offset = "0x1A3AB80", VA = "0x181A3BF80")]
		private void _GeneComparersWithPluginContexts()
		{
		}

		// Token: 0x0602013D RID: 131389 RVA: 0x000B4828 File Offset: 0x000B2A28
		[Token(Token = "0x602013D")]
		[Address(RVA = "0x1A3BDD0", Offset = "0x1A3A9D0", VA = "0x181A3BDD0")]
		private int _CompareCharCardViewModel(RoguelikeCharCardViewModel lhs, RoguelikeCharCardViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0602013E RID: 131390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602013E")]
		[Address(RVA = "0x1A3C8E0", Offset = "0x1A3B4E0", VA = "0x181A3C8E0")]
		public RoguelikeSquadStateBean()
		{
		}

		// Token: 0x0402B505 RID: 177413
		[Token(Token = "0x402B505")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeCharCardViewModel> viewModelList;

		// Token: 0x0402B508 RID: 177416
		[Token(Token = "0x402B508")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<int> m_sharedSet;

		// Token: 0x0402B509 RID: 177417
		[Token(Token = "0x402B509")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, int> m_sharedSkillPref;

		// Token: 0x0402B50A RID: 177418
		[Token(Token = "0x402B50A")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, string> m_sharedBranchPref;

		// Token: 0x0402B50B RID: 177419
		[Token(Token = "0x402B50B")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> m_sharedSkillCounts;

		// Token: 0x0402B50C RID: 177420
		[Token(Token = "0x402B50C")]
		[FieldOffset(Offset = "0x48")]
		private List<IRoguelikeCharCardViewPluginContext> m_pluginContexts;

		// Token: 0x0402B50D RID: 177421
		[Token(Token = "0x402B50D")]
		[FieldOffset(Offset = "0x50")]
		private List<RoguelikeCharCardComparer> m_comparers;

		// Token: 0x0402B50E RID: 177422
		[Token(Token = "0x402B50E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curZoneType;

		// Token: 0x0402B50F RID: 177423
		[Token(Token = "0x402B50F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curZoneType;

		// Token: 0x0402B510 RID: 177424
		[Token(Token = "0x402B510")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402B511 RID: 177425
		[Token(Token = "0x402B511")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402B512 RID: 177426
		[Token(Token = "0x402B512")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_troopCount;

		// Token: 0x0402B513 RID: 177427
		[Token(Token = "0x402B513")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AttachPluginContexts;

		// Token: 0x0402B514 RID: 177428
		[Token(Token = "0x402B514")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B515 RID: 177429
		[Token(Token = "0x402B515")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCurCapacity;

		// Token: 0x0402B516 RID: 177430
		[Token(Token = "0x402B516")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadSquadSkillPref;

		// Token: 0x0402B517 RID: 177431
		[Token(Token = "0x402B517")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadSquadSkillCount;

		// Token: 0x0402B518 RID: 177432
		[Token(Token = "0x402B518")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadSquadBranchPref;

		// Token: 0x0402B519 RID: 177433
		[Token(Token = "0x402B519")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConfirmSquad;

		// Token: 0x0402B51A RID: 177434
		[Token(Token = "0x402B51A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UniformSquad;

		// Token: 0x0402B51B RID: 177435
		[Token(Token = "0x402B51B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetSquadTroopCount;

		// Token: 0x0402B51C RID: 177436
		[Token(Token = "0x402B51C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SaveLocalCache;

		// Token: 0x0402B51D RID: 177437
		[Token(Token = "0x402B51D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryAddTroopToSquad;

		// Token: 0x0402B51E RID: 177438
		[Token(Token = "0x402B51E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GeneComparersWithPluginContexts;

		// Token: 0x0402B51F RID: 177439
		[Token(Token = "0x402B51F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CompareCharCardViewModel;

		// Token: 0x0402B520 RID: 177440
		[Token(Token = "0x402B520")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
