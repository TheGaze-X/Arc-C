using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BD1 RID: 23505
	[Token(Token = "0x2005BD1")]
	public abstract class TemplateCharSelectCardViewModel : IHotfixable
	{
		// Token: 0x17004FC3 RID: 20419
		// (get) Token: 0x06022151 RID: 139601 RVA: 0x000BC508 File Offset: 0x000BA708
		// (set) Token: 0x06022152 RID: 139602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FC3")]
		public bool selected
		{
			[Token(Token = "0x6022151")]
			[Address(RVA = "0x1C9A080", Offset = "0x1C98C80", VA = "0x181C9A080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022152")]
			[Address(RVA = "0x1C9A1C0", Offset = "0x1C98DC0", VA = "0x181C9A1C0")]
			set
			{
			}
		}

		// Token: 0x17004FC4 RID: 20420
		// (get) Token: 0x06022153 RID: 139603 RVA: 0x000BC520 File Offset: 0x000BA720
		[Token(Token = "0x17004FC4")]
		public bool isEmpty
		{
			[Token(Token = "0x6022153")]
			[Address(RVA = "0x1C99FA0", Offset = "0x1C98BA0", VA = "0x181C99FA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x06022154 RID: 139604
		[Token(Token = "0x17004FC5")]
		public abstract ICharacterCardViewModel charBaseModel { [Token(Token = "0x6022154")] get; }

		// Token: 0x06022155 RID: 139605
		[Token(Token = "0x6022155")]
		public abstract AttackRangeDescModel GetAttackRange();

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06022156 RID: 139606
		// (set) Token: 0x06022157 RID: 139607
		[Token(Token = "0x17004FC6")]
		public abstract string skillId { [Token(Token = "0x6022156")] get; [Token(Token = "0x6022157")] set; }

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06022158 RID: 139608
		// (set) Token: 0x06022159 RID: 139609
		[Token(Token = "0x17004FC7")]
		public abstract string equipId { [Token(Token = "0x6022158")] get; [Token(Token = "0x6022159")] set; }

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x0602215A RID: 139610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602215B RID: 139611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FC8")]
		protected CharSelectBranchGroupViewModel branchViewModel
		{
			[Token(Token = "0x602215A")]
			[Address(RVA = "0x1C99F40", Offset = "0x1C98B40", VA = "0x181C99F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602215B")]
			[Address(RVA = "0x1C9A140", Offset = "0x1C98D40", VA = "0x181C9A140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x0602215C RID: 139612 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602215D RID: 139613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FC9")]
		protected CharSelectSkillGroupViewModel skillViewModel
		{
			[Token(Token = "0x602215C")]
			[Address(RVA = "0x1C9A0E0", Offset = "0x1C98CE0", VA = "0x181C9A0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602215D")]
			[Address(RVA = "0x1C9A260", Offset = "0x1C98E60", VA = "0x181C9A260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602215E RID: 139614
		[Token(Token = "0x602215E")]
		public abstract void SynWithPlayerData(TemplateCharSelectController.InputParam cacheInput);

		// Token: 0x0602215F RID: 139615
		[Token(Token = "0x602215F")]
		public abstract int GetInstId();

		// Token: 0x06022160 RID: 139616 RVA: 0x000BC538 File Offset: 0x000BA738
		[Token(Token = "0x6022160")]
		[Address(RVA = "0x1C99080", Offset = "0x1C97C80", VA = "0x181C99080")]
		public bool SetAttribute(int key, ValueBundle value)
		{
			return default(bool);
		}

		// Token: 0x06022161 RID: 139617 RVA: 0x000BC550 File Offset: 0x000BA750
		[Token(Token = "0x6022161")]
		[Address(RVA = "0x1C98FE0", Offset = "0x1C97BE0", VA = "0x181C98FE0", Slot = "12")]
		protected virtual bool OnSetAttribute(int key, ValueBundle value)
		{
			return default(bool);
		}

		// Token: 0x06022162 RID: 139618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022162")]
		[Address(RVA = "0x1C86D60", Offset = "0x1C85960", VA = "0x181C86D60", Slot = "13")]
		protected virtual void OnEquipChanged(string equipId)
		{
		}

		// Token: 0x06022163 RID: 139619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022163")]
		[Address(RVA = "0x1C98F80", Offset = "0x1C97B80", VA = "0x181C98F80", Slot = "14")]
		protected virtual void OnSelectChanged(bool sel)
		{
		}

		// Token: 0x06022164 RID: 139620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022164")]
		[Address(RVA = "0x1C99650", Offset = "0x1C98250", VA = "0x181C99650", Slot = "15")]
		public virtual CharSelectSkillGroupViewModel SetSkillViewModel(bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x06022165 RID: 139621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022165")]
		[Address(RVA = "0x1C99330", Offset = "0x1C97F30", VA = "0x181C99330", Slot = "16")]
		public virtual CharSelectBranchGroupViewModel SetBranchViewModel(bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x06022166 RID: 139622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022166")]
		[Address(RVA = "0x1C998D0", Offset = "0x1C984D0", VA = "0x181C998D0", Slot = "17")]
		protected virtual void UpdateBranchViewModelByInput(TemplateCharSelectCardViewModel.SetBranchGroupInput input, CharacterData charData, bool forceRefresh = false)
		{
		}

		// Token: 0x06022167 RID: 139623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022167")]
		[Address(RVA = "0x1C99ED0", Offset = "0x1C98AD0", VA = "0x181C99ED0")]
		protected TemplateCharSelectCardViewModel()
		{
		}

		// Token: 0x0402EC0B RID: 191499
		[Token(Token = "0x402EC0B")]
		public const int ATTR_SKILL_KEY = 100;

		// Token: 0x0402EC0C RID: 191500
		[Token(Token = "0x402EC0C")]
		public const int ATTR_EQUIP_KEY = 101;

		// Token: 0x0402EC0D RID: 191501
		[Token(Token = "0x402EC0D")]
		[FieldOffset(Offset = "0x10")]
		private bool m_selected;

		// Token: 0x0402EC0E RID: 191502
		[Token(Token = "0x402EC0E")]
		[FieldOffset(Offset = "0x14")]
		public int selectIndex;

		// Token: 0x0402EC11 RID: 191505
		[Token(Token = "0x402EC11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x0402EC12 RID: 191506
		[Token(Token = "0x402EC12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x0402EC13 RID: 191507
		[Token(Token = "0x402EC13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402EC14 RID: 191508
		[Token(Token = "0x402EC14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_branchViewModel;

		// Token: 0x0402EC15 RID: 191509
		[Token(Token = "0x402EC15")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_branchViewModel;

		// Token: 0x0402EC16 RID: 191510
		[Token(Token = "0x402EC16")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_skillViewModel;

		// Token: 0x0402EC17 RID: 191511
		[Token(Token = "0x402EC17")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_skillViewModel;

		// Token: 0x0402EC18 RID: 191512
		[Token(Token = "0x402EC18")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetAttribute;

		// Token: 0x0402EC19 RID: 191513
		[Token(Token = "0x402EC19")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSetAttribute;

		// Token: 0x0402EC1A RID: 191514
		[Token(Token = "0x402EC1A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEquipChanged;

		// Token: 0x0402EC1B RID: 191515
		[Token(Token = "0x402EC1B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSelectChanged;

		// Token: 0x0402EC1C RID: 191516
		[Token(Token = "0x402EC1C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetSkillViewModel;

		// Token: 0x0402EC1D RID: 191517
		[Token(Token = "0x402EC1D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetBranchViewModel;

		// Token: 0x0402EC1E RID: 191518
		[Token(Token = "0x402EC1E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateBranchViewModelByInput;

		// Token: 0x0402EC1F RID: 191519
		[Token(Token = "0x402EC1F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BD2 RID: 23506
		[Token(Token = "0x2005BD2")]
		protected struct SetBranchGroupInput : IHotfixable
		{
			// Token: 0x0402EC20 RID: 191520
			[Token(Token = "0x402EC20")]
			[FieldOffset(Offset = "0x0")]
			public int equipLvl;

			// Token: 0x0402EC21 RID: 191521
			[Token(Token = "0x402EC21")]
			[FieldOffset(Offset = "0x4")]
			public int charLevel;

			// Token: 0x0402EC22 RID: 191522
			[Token(Token = "0x402EC22")]
			[FieldOffset(Offset = "0x8")]
			public EvolvePhase evolvePhase;

			// Token: 0x0402EC23 RID: 191523
			[Token(Token = "0x402EC23")]
			[FieldOffset(Offset = "0xC")]
			public int potentialRank;
		}
	}
}
