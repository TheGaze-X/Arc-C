using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024BD RID: 9405
	[Token(Token = "0x20024BD")]
	public abstract class UIPluginTalent : BasicTalent
	{
		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600F1F5 RID: 61941
		[Token(Token = "0x17001F7F")]
		public abstract UIPluginTalent.PluginType type { [Token(Token = "0x600F1F5")] get; }

		// Token: 0x0600F1F6 RID: 61942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F6")]
		[Address(RVA = "0x698F50", Offset = "0x697B50", VA = "0x180698F50", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F1F7 RID: 61943
		[Token(Token = "0x600F1F7")]
		protected abstract UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName);

		// Token: 0x0600F1F8 RID: 61944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F1F8")]
		[Address(RVA = "0x698C80", Offset = "0x697880", VA = "0x180698C80", Slot = "35")]
		protected virtual UIPluginTalent.UnitTalentUIPlugin CreatePlugin()
		{
			return null;
		}

		// Token: 0x0600F1F9 RID: 61945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1F9")]
		[Address(RVA = "0x699220", Offset = "0x697E20", VA = "0x180699220")]
		private void _OnOwnerFinish(object arg)
		{
		}

		// Token: 0x0600F1FA RID: 61946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1FA")]
		[Address(RVA = "0x699050", Offset = "0x697C50", VA = "0x180699050", Slot = "36")]
		protected virtual void FinishPlugin()
		{
		}

		// Token: 0x0600F1FB RID: 61947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1FB")]
		[Address(RVA = "0x698AC0", Offset = "0x6976C0", VA = "0x180698AC0", Slot = "37")]
		protected virtual void AttachPluginToUI()
		{
		}

		// Token: 0x0600F1FC RID: 61948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1FC")]
		[Address(RVA = "0x6992B0", Offset = "0x697EB0", VA = "0x1806992B0")]
		protected UIPluginTalent()
		{
		}

		// Token: 0x0600F1FD RID: 61949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1FD")]
		[Address(RVA = "0x694060", Offset = "0x692C60", VA = "0x180694060")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x04010BDA RID: 68570
		[Token(Token = "0x4010BDA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("UI Plugin")]
		private string _pluginName;

		// Token: 0x04010BDB RID: 68571
		[Token(Token = "0x4010BDB")]
		[FieldOffset(Offset = "0x58")]
		private ObjectPtr<UIPluginTalent.UnitTalentUIPlugin> m_plugin;

		// Token: 0x04010BDC RID: 68572
		[Token(Token = "0x4010BDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010BDD RID: 68573
		[Token(Token = "0x4010BDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreatePlugin;

		// Token: 0x04010BDE RID: 68574
		[Token(Token = "0x4010BDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnOwnerFinish;

		// Token: 0x04010BDF RID: 68575
		[Token(Token = "0x4010BDF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FinishPlugin;

		// Token: 0x04010BE0 RID: 68576
		[Token(Token = "0x4010BE0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AttachPluginToUI;

		// Token: 0x04010BE1 RID: 68577
		[Token(Token = "0x4010BE1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024BE RID: 9406
		[Token(Token = "0x20024BE")]
		public enum PluginType
		{
			// Token: 0x04010BE3 RID: 68579
			[Token(Token = "0x4010BE3")]
			UNIT_HUD,
			// Token: 0x04010BE4 RID: 68580
			[Token(Token = "0x4010BE4")]
			ALL_UI_CARD,
			// Token: 0x04010BE5 RID: 68581
			[Token(Token = "0x4010BE5")]
			E_NUM
		}

		// Token: 0x020024BF RID: 9407
		[Token(Token = "0x20024BF")]
		public abstract class UnitTalentUIPlugin : MonoBehaviour, IHotfixable, IReusableObject, IReusable, IPtrObject
		{
			// Token: 0x17001F80 RID: 8064
			// (get) Token: 0x0600F1FE RID: 61950 RVA: 0x00059280 File Offset: 0x00057480
			// (set) Token: 0x0600F1FF RID: 61951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001F80")]
			public uint instanceUid
			{
				[Token(Token = "0x600F1FE")]
				[Address(RVA = "0x699FB0", Offset = "0x698BB0", VA = "0x180699FB0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600F1FF")]
				[Address(RVA = "0x69A130", Offset = "0x698D30", VA = "0x18069A130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001F81 RID: 8065
			// (get) Token: 0x0600F200 RID: 61952 RVA: 0x00059298 File Offset: 0x00057498
			// (set) Token: 0x0600F201 RID: 61953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001F81")]
			public bool isAttached
			{
				[Token(Token = "0x600F200")]
				[Address(RVA = "0x69A010", Offset = "0x698C10", VA = "0x18069A010")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600F201")]
				[Address(RVA = "0x69A1A0", Offset = "0x698DA0", VA = "0x18069A1A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001F82 RID: 8066
			// (get) Token: 0x0600F202 RID: 61954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001F82")]
			protected Unit owner
			{
				[Token(Token = "0x600F202")]
				[Address(RVA = "0x69A070", Offset = "0x698C70", VA = "0x18069A070")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001F83 RID: 8067
			// (get) Token: 0x0600F203 RID: 61955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001F83")]
			protected UIPluginTalent talent
			{
				[Token(Token = "0x600F203")]
				[Address(RVA = "0x69A0D0", Offset = "0x698CD0", VA = "0x18069A0D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F204 RID: 61956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F204")]
			[Address(RVA = "0x699E00", Offset = "0x698A00", VA = "0x180699E00", Slot = "7")]
			public virtual void OnAllocate()
			{
			}

			// Token: 0x0600F205 RID: 61957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F205")]
			[Address(RVA = "0x699EB0", Offset = "0x698AB0", VA = "0x180699EB0", Slot = "8")]
			public virtual void OnRecycle()
			{
			}

			// Token: 0x0600F206 RID: 61958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F206")]
			[Address(RVA = "0x6999F0", Offset = "0x6985F0", VA = "0x1806999F0")]
			public void AttachFromOtherPlugin(UIPluginTalent.UnitTalentUIPlugin otherPlugin)
			{
			}

			// Token: 0x0600F207 RID: 61959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F207")]
			[Address(RVA = "0x699B90", Offset = "0x698790", VA = "0x180699B90")]
			public void Attach(Unit owner, UIPluginTalent talent)
			{
			}

			// Token: 0x0600F208 RID: 61960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F208")]
			[Address(RVA = "0x699CC0", Offset = "0x6988C0", VA = "0x180699CC0")]
			public void Detach()
			{
			}

			// Token: 0x0600F209 RID: 61961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F209")]
			[Address(RVA = "0x683020", Offset = "0x681C20", VA = "0x180683020", Slot = "9")]
			protected virtual void DoAttach(Unit owner, UIPluginTalent talent)
			{
			}

			// Token: 0x0600F20A RID: 61962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F20A")]
			[Address(RVA = "0x6830A0", Offset = "0x681CA0", VA = "0x1806830A0", Slot = "10")]
			protected virtual void DoDetach()
			{
			}

			// Token: 0x0600F20B RID: 61963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F20B")]
			[Address(RVA = "0x699DA0", Offset = "0x6989A0", VA = "0x180699DA0")]
			public Transform GetHudPluginTransform()
			{
				return null;
			}

			// Token: 0x0600F20C RID: 61964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F20C")]
			[Address(RVA = "0x699F50", Offset = "0x698B50", VA = "0x180699F50")]
			protected UnitTalentUIPlugin()
			{
			}

			// Token: 0x04010BE6 RID: 68582
			[Token(Token = "0x4010BE6")]
			[FieldOffset(Offset = "0x0")]
			private static uint s_globalCounter;

			// Token: 0x04010BE9 RID: 68585
			[Token(Token = "0x4010BE9")]
			[FieldOffset(Offset = "0x20")]
			private Unit m_owner;

			// Token: 0x04010BEA RID: 68586
			[Token(Token = "0x4010BEA")]
			[FieldOffset(Offset = "0x28")]
			private UIPluginTalent m_talent;

			// Token: 0x04010BEB RID: 68587
			[Token(Token = "0x4010BEB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_instanceUid;

			// Token: 0x04010BEC RID: 68588
			[Token(Token = "0x4010BEC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_instanceUid;

			// Token: 0x04010BED RID: 68589
			[Token(Token = "0x4010BED")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_isAttached;

			// Token: 0x04010BEE RID: 68590
			[Token(Token = "0x4010BEE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_isAttached;

			// Token: 0x04010BEF RID: 68591
			[Token(Token = "0x4010BEF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x04010BF0 RID: 68592
			[Token(Token = "0x4010BF0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_talent;

			// Token: 0x04010BF1 RID: 68593
			[Token(Token = "0x4010BF1")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x04010BF2 RID: 68594
			[Token(Token = "0x4010BF2")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnRecycle;

			// Token: 0x04010BF3 RID: 68595
			[Token(Token = "0x4010BF3")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_AttachFromOtherPlugin;

			// Token: 0x04010BF4 RID: 68596
			[Token(Token = "0x4010BF4")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Attach;

			// Token: 0x04010BF5 RID: 68597
			[Token(Token = "0x4010BF5")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Detach;

			// Token: 0x04010BF6 RID: 68598
			[Token(Token = "0x4010BF6")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_DoAttach;

			// Token: 0x04010BF7 RID: 68599
			[Token(Token = "0x4010BF7")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_DoDetach;

			// Token: 0x04010BF8 RID: 68600
			[Token(Token = "0x4010BF8")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GetHudPluginTransform;

			// Token: 0x04010BF9 RID: 68601
			[Token(Token = "0x4010BF9")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
