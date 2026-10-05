using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007162 RID: 29026
	[Token(Token = "0x2007162")]
	public class Act9D0EntryMissionView : ActivityStageComponent, IHotfixable
	{
		// Token: 0x0602936E RID: 168814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602936E")]
		[Address(RVA = "0x2493950", Offset = "0x2492550", VA = "0x182493950", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602936F RID: 168815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602936F")]
		[Address(RVA = "0x24937C0", Offset = "0x24923C0", VA = "0x1824937C0", Slot = "5")]
		protected override void BeforeUnload()
		{
		}

		// Token: 0x06029370 RID: 168816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029370")]
		[Address(RVA = "0x2493AF0", Offset = "0x24926F0", VA = "0x182493AF0")]
		public void _LoadMissionData([Optional] object _)
		{
		}

		// Token: 0x06029371 RID: 168817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029371")]
		[Address(RVA = "0x2493D40", Offset = "0x2492940", VA = "0x182493D40")]
		private void _TryLoadMissionData()
		{
		}

		// Token: 0x06029372 RID: 168818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029372")]
		[Address(RVA = "0x2494010", Offset = "0x2492C10", VA = "0x182494010")]
		private void _TryUpdateMission(object progress)
		{
		}

		// Token: 0x06029373 RID: 168819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029373")]
		[Address(RVA = "0x24941A0", Offset = "0x2492DA0", VA = "0x1824941A0")]
		public Act9D0EntryMissionView()
		{
		}

		// Token: 0x06029374 RID: 168820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029374")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06029375 RID: 168821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029375")]
		[Address(RVA = "0x22E9250", Offset = "0x22E7E50", VA = "0x1822E9250")]
		private void <>xLuaBaseProxy_BeforeUnload()
		{
		}

		// Token: 0x0403AD7C RID: 241020
		[Token(Token = "0x403AD7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _missionText;

		// Token: 0x0403AD7D RID: 241021
		[Token(Token = "0x403AD7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0403AD7E RID: 241022
		[Token(Token = "0x403AD7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_missionNum;

		// Token: 0x0403AD7F RID: 241023
		[Token(Token = "0x403AD7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_missionSum;

		// Token: 0x0403AD80 RID: 241024
		[Token(Token = "0x403AD80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403AD81 RID: 241025
		[Token(Token = "0x403AD81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x0403AD82 RID: 241026
		[Token(Token = "0x403AD82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadMissionData;

		// Token: 0x0403AD83 RID: 241027
		[Token(Token = "0x403AD83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLoadMissionData;

		// Token: 0x0403AD84 RID: 241028
		[Token(Token = "0x403AD84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryUpdateMission;

		// Token: 0x0403AD85 RID: 241029
		[Token(Token = "0x403AD85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
