using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002354 RID: 9044
	[Token(Token = "0x2002354")]
	public class UnitHudPluginManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x0600E4D3 RID: 58579 RVA: 0x00052BA8 File Offset: 0x00050DA8
		[Token(Token = "0x17001CA0")]
		private bool filterById
		{
			[Token(Token = "0x600E4D3")]
			[Address(RVA = "0x5B09B0", Offset = "0x5AF5B0", VA = "0x1805B09B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x0600E4D4 RID: 58580 RVA: 0x00052BC0 File Offset: 0x00050DC0
		[Token(Token = "0x17001CA1")]
		private bool filterByGroupTag
		{
			[Token(Token = "0x600E4D4")]
			[Address(RVA = "0x5B0950", Offset = "0x5AF550", VA = "0x1805B0950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CA2")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E4D5")]
			[Address(RVA = "0x5B0730", Offset = "0x5AF330", VA = "0x1805B0730", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4D6")]
		[Address(RVA = "0x5AFE40", Offset = "0x5AEA40", VA = "0x1805AFE40", Slot = "8")]
		public override void OnPostInit()
		{
		}

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4D7")]
		[Address(RVA = "0x5B00B0", Offset = "0x5AECB0", VA = "0x1805B00B0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4D8")]
		[Address(RVA = "0x5B03E0", Offset = "0x5AEFE0", VA = "0x1805B03E0")]
		private void _TryAttachPlugin(object arg)
		{
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4D9")]
		[Address(RVA = "0x5B0130", Offset = "0x5AED30", VA = "0x1805B0130")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E4DA RID: 58586 RVA: 0x00052BD8 File Offset: 0x00050DD8
		[Token(Token = "0x600E4DA")]
		[Address(RVA = "0x5AF860", Offset = "0x5AE460", VA = "0x1805AF860")]
		private bool CheckUnitValid(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600E4DB RID: 58587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4DB")]
		[Address(RVA = "0x5AFD40", Offset = "0x5AE940", VA = "0x1805AFD40")]
		protected UnitHudPluginManager.HudPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600E4DC RID: 58588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4DC")]
		[Address(RVA = "0x5AFAE0", Offset = "0x5AE6E0", VA = "0x1805AFAE0", Slot = "16")]
		protected virtual UnitHudPluginManager.HudPlugin CreatePlugin(Unit unit)
		{
			return null;
		}

		// Token: 0x0600E4DD RID: 58589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4DD")]
		[Address(RVA = "0x5B05F0", Offset = "0x5AF1F0", VA = "0x1805B05F0")]
		public UnitHudPluginManager()
		{
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4DE")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4DF")]
		[Address(RVA = "0x590AE0", Offset = "0x58F6E0", VA = "0x180590AE0")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0400FC43 RID: 64579
		[Token(Token = "0x400FC43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _pluginName;

		// Token: 0x0400FC44 RID: 64580
		[Token(Token = "0x400FC44")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _characterClassOnly;

		// Token: 0x0400FC45 RID: 64581
		[Token(Token = "0x400FC45")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _enemyClassOnly;

		// Token: 0x0400FC46 RID: 64582
		[Token(Token = "0x400FC46")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool _filterById;

		// Token: 0x0400FC47 RID: 64583
		[Token(Token = "0x400FC47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Inspect("filterById")]
		private List<string> _entityIds;

		// Token: 0x0400FC48 RID: 64584
		[Token(Token = "0x400FC48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _filterByGroupTag;

		// Token: 0x0400FC49 RID: 64585
		[Token(Token = "0x400FC49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Inspect("filterByGroupTag")]
		private List<string> _groupTags;

		// Token: 0x0400FC4A RID: 64586
		[Token(Token = "0x400FC4A")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<uint, UnitHudPluginManager.HudPlugin> m_plugin;

		// Token: 0x0400FC4B RID: 64587
		[Token(Token = "0x400FC4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterById;

		// Token: 0x0400FC4C RID: 64588
		[Token(Token = "0x400FC4C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_filterByGroupTag;

		// Token: 0x0400FC4D RID: 64589
		[Token(Token = "0x400FC4D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FC4E RID: 64590
		[Token(Token = "0x400FC4E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400FC4F RID: 64591
		[Token(Token = "0x400FC4F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FC50 RID: 64592
		[Token(Token = "0x400FC50")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryAttachPlugin;

		// Token: 0x0400FC51 RID: 64593
		[Token(Token = "0x400FC51")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FC52 RID: 64594
		[Token(Token = "0x400FC52")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckUnitValid;

		// Token: 0x0400FC53 RID: 64595
		[Token(Token = "0x400FC53")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x0400FC54 RID: 64596
		[Token(Token = "0x400FC54")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreatePlugin;

		// Token: 0x0400FC55 RID: 64597
		[Token(Token = "0x400FC55")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002355 RID: 9045
		[Token(Token = "0x2002355")]
		public class HudPlugin : MonoBehaviour, IHotfixable, IReusableObject, IReusable, IPtrObject
		{
			// Token: 0x17001CA3 RID: 7331
			// (get) Token: 0x0600E4E0 RID: 58592 RVA: 0x00052BF0 File Offset: 0x00050DF0
			// (set) Token: 0x0600E4E1 RID: 58593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001CA3")]
			public uint instanceUid
			{
				[Token(Token = "0x600E4E0")]
				[Address(RVA = "0x5971C0", Offset = "0x595DC0", VA = "0x1805971C0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600E4E1")]
				[Address(RVA = "0x5972E0", Offset = "0x595EE0", VA = "0x1805972E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600E4E2 RID: 58594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4E2")]
			[Address(RVA = "0x597010", Offset = "0x595C10", VA = "0x180597010", Slot = "7")]
			public virtual void OnAllocate()
			{
			}

			// Token: 0x0600E4E3 RID: 58595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4E3")]
			[Address(RVA = "0x5970C0", Offset = "0x595CC0", VA = "0x1805970C0", Slot = "8")]
			public virtual void OnRecycle()
			{
			}

			// Token: 0x17001CA4 RID: 7332
			// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001CA4")]
			protected Unit owner
			{
				[Token(Token = "0x600E4E4")]
				[Address(RVA = "0x597280", Offset = "0x595E80", VA = "0x180597280")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001CA5 RID: 7333
			// (get) Token: 0x0600E4E5 RID: 58597 RVA: 0x00052C08 File Offset: 0x00050E08
			// (set) Token: 0x0600E4E6 RID: 58598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001CA5")]
			public bool isAttached
			{
				[Token(Token = "0x600E4E5")]
				[Address(RVA = "0x597220", Offset = "0x595E20", VA = "0x180597220")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600E4E6")]
				[Address(RVA = "0x597350", Offset = "0x595F50", VA = "0x180597350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600E4E7 RID: 58599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4E7")]
			[Address(RVA = "0x596CF0", Offset = "0x5958F0", VA = "0x180596CF0")]
			public void Attach(Unit owner)
			{
			}

			// Token: 0x0600E4E8 RID: 58600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4E8")]
			[Address(RVA = "0x596DE0", Offset = "0x5959E0", VA = "0x180596DE0")]
			public void Detach()
			{
			}

			// Token: 0x0600E4E9 RID: 58601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4E9")]
			[Address(RVA = "0x596EF0", Offset = "0x595AF0", VA = "0x180596EF0", Slot = "9")]
			protected virtual void DoAttach(Unit owner)
			{
			}

			// Token: 0x0600E4EA RID: 58602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4EA")]
			[Address(RVA = "0x596F50", Offset = "0x595B50", VA = "0x180596F50", Slot = "10")]
			protected virtual void DoDetach()
			{
			}

			// Token: 0x0600E4EB RID: 58603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E4EB")]
			[Address(RVA = "0x596FB0", Offset = "0x595BB0", VA = "0x180596FB0")]
			public Transform GetHudPluginTransform()
			{
				return null;
			}

			// Token: 0x0600E4EC RID: 58604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4EC")]
			[Address(RVA = "0x597160", Offset = "0x595D60", VA = "0x180597160")]
			public HudPlugin()
			{
			}

			// Token: 0x0400FC56 RID: 64598
			[Token(Token = "0x400FC56")]
			[FieldOffset(Offset = "0x18")]
			private Unit m_owner;

			// Token: 0x0400FC57 RID: 64599
			[Token(Token = "0x400FC57")]
			[FieldOffset(Offset = "0x0")]
			private static uint s_globalCounter;

			// Token: 0x0400FC5A RID: 64602
			[Token(Token = "0x400FC5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_instanceUid;

			// Token: 0x0400FC5B RID: 64603
			[Token(Token = "0x400FC5B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_instanceUid;

			// Token: 0x0400FC5C RID: 64604
			[Token(Token = "0x400FC5C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnAllocate;

			// Token: 0x0400FC5D RID: 64605
			[Token(Token = "0x400FC5D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnRecycle;

			// Token: 0x0400FC5E RID: 64606
			[Token(Token = "0x400FC5E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x0400FC5F RID: 64607
			[Token(Token = "0x400FC5F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isAttached;

			// Token: 0x0400FC60 RID: 64608
			[Token(Token = "0x400FC60")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_isAttached;

			// Token: 0x0400FC61 RID: 64609
			[Token(Token = "0x400FC61")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_Attach;

			// Token: 0x0400FC62 RID: 64610
			[Token(Token = "0x400FC62")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Detach;

			// Token: 0x0400FC63 RID: 64611
			[Token(Token = "0x400FC63")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_DoAttach;

			// Token: 0x0400FC64 RID: 64612
			[Token(Token = "0x400FC64")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_DoDetach;

			// Token: 0x0400FC65 RID: 64613
			[Token(Token = "0x400FC65")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_GetHudPluginTransform;

			// Token: 0x0400FC66 RID: 64614
			[Token(Token = "0x400FC66")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
