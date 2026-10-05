using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003355 RID: 13141
	[Token(Token = "0x2003355")]
	public class AVGAdapter : ExecutorComponent
	{
		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x06014F7E RID: 85886 RVA: 0x00089CA0 File Offset: 0x00087EA0
		// (set) Token: 0x06014F7F RID: 85887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031C2")]
		public bool maskOn
		{
			[Token(Token = "0x6014F7E")]
			[Address(RVA = "0xD50B30", Offset = "0xD4F730", VA = "0x180D50B30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014F7F")]
			[Address(RVA = "0xD50BA0", Offset = "0xD4F7A0", VA = "0x180D50BA0")]
			private set
			{
			}
		}

		// Token: 0x06014F80 RID: 85888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014F80")]
		[Address(RVA = "0xD4F8C0", Offset = "0xD4E4C0", VA = "0x180D4F8C0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06014F81 RID: 85889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F81")]
		[Address(RVA = "0xD4F860", Offset = "0xD4E460", VA = "0x180D4F860", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06014F82 RID: 85890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F82")]
		[Address(RVA = "0xD50810", Offset = "0xD4F410", VA = "0x180D50810")]
		private void _OnStoryBegin(object arg)
		{
		}

		// Token: 0x06014F83 RID: 85891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F83")]
		[Address(RVA = "0xD509D0", Offset = "0xD4F5D0", VA = "0x180D509D0")]
		private void _OnStoryEnd(object arg)
		{
		}

		// Token: 0x06014F84 RID: 85892 RVA: 0x00089CB8 File Offset: 0x00087EB8
		[Token(Token = "0x6014F84")]
		[Address(RVA = "0xD50540", Offset = "0xD4F140", VA = "0x180D50540")]
		private bool _ExecutePause(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F85 RID: 85893 RVA: 0x00089CD0 File Offset: 0x00087ED0
		[Token(Token = "0x6014F85")]
		[Address(RVA = "0xD500A0", Offset = "0xD4ECA0", VA = "0x180D500A0")]
		private bool _ExecuteBattleDelay(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F86 RID: 85894 RVA: 0x00089CE8 File Offset: 0x00087EE8
		[Token(Token = "0x6014F86")]
		[Address(RVA = "0xD50730", Offset = "0xD4F330", VA = "0x180D50730")]
		private bool _ExecuteUnlockFunction(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F87 RID: 85895 RVA: 0x00089D00 File Offset: 0x00087F00
		[Token(Token = "0x6014F87")]
		[Address(RVA = "0xD50460", Offset = "0xD4F060", VA = "0x180D50460")]
		private bool _ExecuteLockFunction(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F88 RID: 85896 RVA: 0x00089D18 File Offset: 0x00087F18
		[Token(Token = "0x6014F88")]
		[Address(RVA = "0xD50210", Offset = "0xD4EE10", VA = "0x180D50210")]
		private bool _ExecuteEnsureMinCost(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F89 RID: 85897 RVA: 0x00089D30 File Offset: 0x00087F30
		[Token(Token = "0x6014F89")]
		[Address(RVA = "0xD502E0", Offset = "0xD4EEE0", VA = "0x180D502E0")]
		private bool _ExecuteEnsureMinSp(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F8A RID: 85898 RVA: 0x00089D48 File Offset: 0x00087F48
		[Token(Token = "0x6014F8A")]
		[Address(RVA = "0xD50670", Offset = "0xD4F270", VA = "0x180D50670")]
		private bool _ExecuteSwitchToDefaultUIState(Command command)
		{
			return default(bool);
		}

		// Token: 0x06014F8B RID: 85899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F8B")]
		[Address(RVA = "0xD4FE40", Offset = "0xD4EA40", VA = "0x180D4FE40")]
		private void Start()
		{
		}

		// Token: 0x06014F8C RID: 85900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F8C")]
		[Address(RVA = "0xD4FC90", Offset = "0xD4E890", VA = "0x180D4FC90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014F8D RID: 85901 RVA: 0x00089D60 File Offset: 0x00087F60
		[Token(Token = "0x6014F8D")]
		[Address(RVA = "0xD50010", Offset = "0xD4EC10", VA = "0x180D50010")]
		private bool _BattleNotPause()
		{
			return default(bool);
		}

		// Token: 0x06014F8E RID: 85902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F8E")]
		[Address(RVA = "0xD50AD0", Offset = "0xD4F6D0", VA = "0x180D50AD0")]
		public AVGAdapter()
		{
		}

		// Token: 0x04018F0E RID: 102158
		[Token(Token = "0x4018F0E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _mask;

		// Token: 0x04018F0F RID: 102159
		[Token(Token = "0x4018F0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maskOn;

		// Token: 0x04018F10 RID: 102160
		[Token(Token = "0x4018F10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_maskOn;

		// Token: 0x04018F11 RID: 102161
		[Token(Token = "0x4018F11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x04018F12 RID: 102162
		[Token(Token = "0x4018F12")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x04018F13 RID: 102163
		[Token(Token = "0x4018F13")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnStoryBegin;

		// Token: 0x04018F14 RID: 102164
		[Token(Token = "0x4018F14")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStoryEnd;

		// Token: 0x04018F15 RID: 102165
		[Token(Token = "0x4018F15")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecutePause;

		// Token: 0x04018F16 RID: 102166
		[Token(Token = "0x4018F16")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteBattleDelay;

		// Token: 0x04018F17 RID: 102167
		[Token(Token = "0x4018F17")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteUnlockFunction;

		// Token: 0x04018F18 RID: 102168
		[Token(Token = "0x4018F18")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExecuteLockFunction;

		// Token: 0x04018F19 RID: 102169
		[Token(Token = "0x4018F19")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExecuteEnsureMinCost;

		// Token: 0x04018F1A RID: 102170
		[Token(Token = "0x4018F1A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecuteEnsureMinSp;

		// Token: 0x04018F1B RID: 102171
		[Token(Token = "0x4018F1B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExecuteSwitchToDefaultUIState;

		// Token: 0x04018F1C RID: 102172
		[Token(Token = "0x4018F1C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04018F1D RID: 102173
		[Token(Token = "0x4018F1D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018F1E RID: 102174
		[Token(Token = "0x4018F1E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__BattleNotPause;

		// Token: 0x04018F1F RID: 102175
		[Token(Token = "0x4018F1F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
