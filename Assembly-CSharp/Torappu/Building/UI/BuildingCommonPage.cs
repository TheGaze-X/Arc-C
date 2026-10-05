using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B74 RID: 7028
	[Token(Token = "0x2001B74")]
	public abstract class BuildingCommonPage : StateEnginePage, IBuildingPage
	{
		// Token: 0x14000058 RID: 88
		// (add) Token: 0x0600B010 RID: 45072 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B011 RID: 45073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000058")]
		public event Action eventPlayerDataChanged
		{
			[Token(Token = "0x600B010")]
			[Address(RVA = "0x32A3E10", Offset = "0x32A2A10", VA = "0x1832A3E10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B011")]
			[Address(RVA = "0x32A3EF0", Offset = "0x32A2AF0", VA = "0x1832A3EF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600B012 RID: 45074 RVA: 0x00043620 File Offset: 0x00041820
		[Token(Token = "0x600B012")]
		[Address(RVA = "0x32A2490", Offset = "0x32A1090", VA = "0x1832A2490", Slot = "29")]
		public bool CanInteractBuilding()
		{
			return default(bool);
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B013")]
		[Address(RVA = "0x32A2570", Offset = "0x32A1170", VA = "0x1832A2570", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B014")]
		[Address(RVA = "0x32A2950", Offset = "0x32A1550", VA = "0x1832A2950", Slot = "9")]
		protected override void OnReuse(DataBundle savedInstance)
		{
		}

		// Token: 0x0600B015 RID: 45077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B015")]
		[Address(RVA = "0x32A27B0", Offset = "0x32A13B0", VA = "0x1832A27B0", Slot = "15")]
		protected override void OnRecycle()
		{
		}

		// Token: 0x0600B016 RID: 45078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B016")]
		[Address(RVA = "0x32A25F0", Offset = "0x32A11F0", VA = "0x1832A25F0", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600B017 RID: 45079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B017")]
		[Address(RVA = "0x32A3680", Offset = "0x32A2280", VA = "0x1832A3680", Slot = "30")]
		public virtual ListDict<BuildingEvent, EventPool.EventCallbackDelegate> RegisterBuildingEvents()
		{
			return null;
		}

		// Token: 0x0600B018 RID: 45080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B018")]
		[Address(RVA = "0x32A36E0", Offset = "0x32A22E0", VA = "0x1832A36E0")]
		public void RouterOnlyResetToDefaultStateAndNotifyRouted()
		{
		}

		// Token: 0x0600B019 RID: 45081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B019")]
		[Address(RVA = "0x32A3D00", Offset = "0x32A2900", VA = "0x1832A3D00")]
		private IEnumerator _ResetAndNotifyRoutedCoroutine()
		{
			return null;
		}

		// Token: 0x0600B01A RID: 45082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B01A")]
		[Address(RVA = "0x32A3880", Offset = "0x32A2480", VA = "0x1832A3880")]
		private void _AttachToContext()
		{
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B01B")]
		[Address(RVA = "0x32A39C0", Offset = "0x32A25C0", VA = "0x1832A39C0")]
		private void _DetachFromContext()
		{
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B01C")]
		[Address(RVA = "0x32A3B90", Offset = "0x32A2790", VA = "0x1832A3B90")]
		private void _RemoveRefContext()
		{
		}

		// Token: 0x0600B01D RID: 45085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B01D")]
		[Address(RVA = "0x32A3B10", Offset = "0x32A2710", VA = "0x1832A3B10")]
		private void _OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B01E")]
		[Address(RVA = "0x32A24F0", Offset = "0x32A10F0", VA = "0x1832A24F0")]
		public void NextStationSelectConfirmed(Action callback)
		{
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B01F")]
		[Address(RVA = "0x32A37E0", Offset = "0x32A23E0", VA = "0x1832A37E0")]
		public void StationSelectOnly_NotifyStateExit(bool isConfirmed)
		{
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B020")]
		[Address(RVA = "0x32A2C80", Offset = "0x32A1880", VA = "0x1832A2C80")]
		public static void OpenCharSelectPage(string slotId, int index, [Optional] string roomTarget)
		{
		}

		// Token: 0x0600B021 RID: 45089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B021")]
		[Address(RVA = "0x32A29D0", Offset = "0x32A15D0", VA = "0x1832A29D0")]
		public static void OpenCharSelectPageForPreQueueEdit(BuildingModel buildingModel, string slotId, int indexInQueueList)
		{
		}

		// Token: 0x0600B022 RID: 45090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B022")]
		[Address(RVA = "0x32A3DB0", Offset = "0x32A29B0", VA = "0x1832A3DB0")]
		protected BuildingCommonPage()
		{
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B023")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0600B024 RID: 45092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B024")]
		[Address(RVA = "0x1551CD0", Offset = "0x15508D0", VA = "0x181551CD0")]
		private void <>xLuaBaseProxy_OnReuse(DataBundle P0)
		{
		}

		// Token: 0x0600B025 RID: 45093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B025")]
		[Address(RVA = "0xF93B70", Offset = "0xF92770", VA = "0x180F93B70")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0600B026 RID: 45094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B026")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0400AA5E RID: 43614
		[Token(Token = "0x400AA5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Tooltip("If true the user could manip building through the page")]
		private bool _canInteractBuilding;

		// Token: 0x0400AA60 RID: 43616
		[Token(Token = "0x400AA60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Action m_onNextStationConfirmed;

		// Token: 0x0400AA61 RID: 43617
		[Token(Token = "0x400AA61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RefCountReference m_buildingContextRef;

		// Token: 0x0400AA62 RID: 43618
		[Token(Token = "0x400AA62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private IBuildingContext m_refedContext;

		// Token: 0x0400AA63 RID: 43619
		[Token(Token = "0x400AA63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eventPlayerDataChanged;

		// Token: 0x0400AA64 RID: 43620
		[Token(Token = "0x400AA64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eventPlayerDataChanged;

		// Token: 0x0400AA65 RID: 43621
		[Token(Token = "0x400AA65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CanInteractBuilding;

		// Token: 0x0400AA66 RID: 43622
		[Token(Token = "0x400AA66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0400AA67 RID: 43623
		[Token(Token = "0x400AA67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnReuse;

		// Token: 0x0400AA68 RID: 43624
		[Token(Token = "0x400AA68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0400AA69 RID: 43625
		[Token(Token = "0x400AA69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400AA6A RID: 43626
		[Token(Token = "0x400AA6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterBuildingEvents;

		// Token: 0x0400AA6B RID: 43627
		[Token(Token = "0x400AA6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RouterOnlyResetToDefaultStateAndNotifyRouted;

		// Token: 0x0400AA6C RID: 43628
		[Token(Token = "0x400AA6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetAndNotifyRoutedCoroutine;

		// Token: 0x0400AA6D RID: 43629
		[Token(Token = "0x400AA6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AttachToContext;

		// Token: 0x0400AA6E RID: 43630
		[Token(Token = "0x400AA6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DetachFromContext;

		// Token: 0x0400AA6F RID: 43631
		[Token(Token = "0x400AA6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RemoveRefContext;

		// Token: 0x0400AA70 RID: 43632
		[Token(Token = "0x400AA70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400AA71 RID: 43633
		[Token(Token = "0x400AA71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_NextStationSelectConfirmed;

		// Token: 0x0400AA72 RID: 43634
		[Token(Token = "0x400AA72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_StationSelectOnly_NotifyStateExit;

		// Token: 0x0400AA73 RID: 43635
		[Token(Token = "0x400AA73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OpenCharSelectPage;

		// Token: 0x0400AA74 RID: 43636
		[Token(Token = "0x400AA74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OpenCharSelectPageForPreQueueEdit;

		// Token: 0x0400AA75 RID: 43637
		[Token(Token = "0x400AA75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B75 RID: 7029
		[Token(Token = "0x2001B75")]
		public struct Param
		{
			// Token: 0x0400AA76 RID: 43638
			[Token(Token = "0x400AA76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ItemBundle targetItem;
		}
	}
}
