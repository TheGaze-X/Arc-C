using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007031 RID: 28721
	[Token(Token = "0x2007031")]
	public abstract class ActMultiV3PrepareMainStepPanelBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700604C RID: 24652
		// (get) Token: 0x06028C4F RID: 166991 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028C50 RID: 166992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700604C")]
		private protected ActMultiV3PrepareMainState mainState
		{
			[Token(Token = "0x6028C4F")]
			[Address(RVA = "0x240B9D0", Offset = "0x240A5D0", VA = "0x18240B9D0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6028C50")]
			[Address(RVA = "0x240BB00", Offset = "0x240A700", VA = "0x18240BB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700604D RID: 24653
		// (get) Token: 0x06028C51 RID: 166993 RVA: 0x000D2F18 File Offset: 0x000D1118
		// (set) Token: 0x06028C52 RID: 166994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700604D")]
		private protected ActMultiV3PrepareMainStepPanelBase.MainParam mainParam
		{
			[Token(Token = "0x6028C51")]
			[Address(RVA = "0x240B920", Offset = "0x240A520", VA = "0x18240B920")]
			[CompilerGenerated]
			protected get
			{
				return default(ActMultiV3PrepareMainStepPanelBase.MainParam);
			}
			[Token(Token = "0x6028C52")]
			[Address(RVA = "0x240BA30", Offset = "0x240A630", VA = "0x18240BA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700604E RID: 24654
		// (get) Token: 0x06028C53 RID: 166995
		[Token(Token = "0x1700604E")]
		public abstract ActMultiV3PrepareStepType step { [Token(Token = "0x6028C53")] get; }

		// Token: 0x06028C54 RID: 166996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C54")]
		[Address(RVA = "0x240B500", Offset = "0x240A100", VA = "0x18240B500")]
		public void UpdatePanel(ActMultiV3PrepareMainViewModel model, ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028C55 RID: 166997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C55")]
		[Address(RVA = "0x240AB40", Offset = "0x2409740", VA = "0x18240AB40")]
		public void Init(ActMultiV3PrepareMainState state)
		{
		}

		// Token: 0x06028C56 RID: 166998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C56")]
		[Address(RVA = "0x240B3B0", Offset = "0x2409FB0", VA = "0x18240B3B0")]
		public void Stop()
		{
		}

		// Token: 0x06028C57 RID: 166999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C57")]
		[Address(RVA = "0x240ACA0", Offset = "0x24098A0", VA = "0x18240ACA0", Slot = "5")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06028C58 RID: 167000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C58")]
		[Address(RVA = "0x240AD60", Offset = "0x2409960", VA = "0x18240AD60", Slot = "6")]
		protected virtual void OnStop()
		{
		}

		// Token: 0x06028C59 RID: 167001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C59")]
		[Address(RVA = "0x240ADC0", Offset = "0x24099C0", VA = "0x18240ADC0", Slot = "7")]
		protected virtual void OnUpdate(ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028C5A RID: 167002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C5A")]
		[Address(RVA = "0x240AE20", Offset = "0x2409A20", VA = "0x18240AE20", Slot = "8")]
		protected virtual void OnVisible(bool v)
		{
		}

		// Token: 0x06028C5B RID: 167003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C5B")]
		[Address(RVA = "0x240AC40", Offset = "0x2409840", VA = "0x18240AC40", Slot = "9")]
		protected virtual void OnEmergency()
		{
		}

		// Token: 0x06028C5C RID: 167004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C5C")]
		[Address(RVA = "0x240B440", Offset = "0x240A040", VA = "0x18240B440")]
		public IEnumerator SwitchVisible(bool v)
		{
			return null;
		}

		// Token: 0x06028C5D RID: 167005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C5D")]
		[Address(RVA = "0x240AFA0", Offset = "0x2409BA0", VA = "0x18240AFA0")]
		public void ResetVisible(bool v)
		{
		}

		// Token: 0x06028C5E RID: 167006
		[Token(Token = "0x6028C5E")]
		public abstract ActMultiV3PrepareMainViewConfig GetMainViewConfig();

		// Token: 0x06028C5F RID: 167007 RVA: 0x000D2F30 File Offset: 0x000D1130
		[Token(Token = "0x6028C5F")]
		[Address(RVA = "0x240AAE0", Offset = "0x24096E0", VA = "0x18240AAE0", Slot = "11")]
		public virtual bool DoBackAction()
		{
			return default(bool);
		}

		// Token: 0x06028C60 RID: 167008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C60")]
		[Address(RVA = "0x240B810", Offset = "0x240A410", VA = "0x18240B810")]
		private IEnumerator _ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06028C61 RID: 167009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C61")]
		[Address(RVA = "0x240B760", Offset = "0x240A360", VA = "0x18240B760")]
		private IEnumerator _HideCoroutine()
		{
			return null;
		}

		// Token: 0x06028C62 RID: 167010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C62")]
		[Address(RVA = "0x240AE80", Offset = "0x2409A80", VA = "0x18240AE80", Slot = "12")]
		protected virtual IEnumerator PlayEntryAnimation()
		{
			return null;
		}

		// Token: 0x06028C63 RID: 167011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C63")]
		[Address(RVA = "0x240AF10", Offset = "0x2409B10", VA = "0x18240AF10", Slot = "13")]
		protected virtual IEnumerator PlayExitAnimation()
		{
			return null;
		}

		// Token: 0x06028C64 RID: 167012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C64")]
		[Address(RVA = "0x240AD00", Offset = "0x2409900", VA = "0x18240AD00", Slot = "14")]
		protected virtual void OnResetVisible(bool v)
		{
		}

		// Token: 0x06028C65 RID: 167013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C65")]
		[Address(RVA = "0x240B1F0", Offset = "0x2409DF0", VA = "0x18240B1F0")]
		protected void SetPopupViewLayer(GameObject viewGO)
		{
		}

		// Token: 0x06028C66 RID: 167014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C66")]
		[Address(RVA = "0x240B8C0", Offset = "0x240A4C0", VA = "0x18240B8C0")]
		protected ActMultiV3PrepareMainStepPanelBase()
		{
		}

		// Token: 0x0403A226 RID: 238118
		[Token(Token = "0x403A226")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<GameObject> m_views;

		// Token: 0x0403A227 RID: 238119
		[Token(Token = "0x403A227")]
		[FieldOffset(Offset = "0x20")]
		private bool m_visible;

		// Token: 0x0403A228 RID: 238120
		[Token(Token = "0x403A228")]
		[FieldOffset(Offset = "0x21")]
		private bool m_cachedIsInEmergency;

		// Token: 0x0403A22B RID: 238123
		[Token(Token = "0x403A22B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainState;

		// Token: 0x0403A22C RID: 238124
		[Token(Token = "0x403A22C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mainState;

		// Token: 0x0403A22D RID: 238125
		[Token(Token = "0x403A22D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mainParam;

		// Token: 0x0403A22E RID: 238126
		[Token(Token = "0x403A22E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_mainParam;

		// Token: 0x0403A22F RID: 238127
		[Token(Token = "0x403A22F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePanel;

		// Token: 0x0403A230 RID: 238128
		[Token(Token = "0x403A230")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403A231 RID: 238129
		[Token(Token = "0x403A231")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0403A232 RID: 238130
		[Token(Token = "0x403A232")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A233 RID: 238131
		[Token(Token = "0x403A233")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0403A234 RID: 238132
		[Token(Token = "0x403A234")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A235 RID: 238133
		[Token(Token = "0x403A235")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnVisible;

		// Token: 0x0403A236 RID: 238134
		[Token(Token = "0x403A236")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEmergency;

		// Token: 0x0403A237 RID: 238135
		[Token(Token = "0x403A237")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SwitchVisible;

		// Token: 0x0403A238 RID: 238136
		[Token(Token = "0x403A238")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ResetVisible;

		// Token: 0x0403A239 RID: 238137
		[Token(Token = "0x403A239")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DoBackAction;

		// Token: 0x0403A23A RID: 238138
		[Token(Token = "0x403A23A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ShowCoroutine;

		// Token: 0x0403A23B RID: 238139
		[Token(Token = "0x403A23B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HideCoroutine;

		// Token: 0x0403A23C RID: 238140
		[Token(Token = "0x403A23C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_PlayEntryAnimation;

		// Token: 0x0403A23D RID: 238141
		[Token(Token = "0x403A23D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_PlayExitAnimation;

		// Token: 0x0403A23E RID: 238142
		[Token(Token = "0x403A23E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnResetVisible;

		// Token: 0x0403A23F RID: 238143
		[Token(Token = "0x403A23F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetPopupViewLayer;

		// Token: 0x0403A240 RID: 238144
		[Token(Token = "0x403A240")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007032 RID: 28722
		[Token(Token = "0x2007032")]
		protected struct MainParam
		{
			// Token: 0x0403A241 RID: 238145
			[Token(Token = "0x403A241")]
			[FieldOffset(Offset = "0x0")]
			public string activityId;
		}
	}
}
