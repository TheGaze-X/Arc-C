using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200405F RID: 16479
	[Token(Token = "0x200405F")]
	public abstract class SandboxV2AdminMainTabPanel : SandboxV2AdminMainViewBase
	{
		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x060197CD RID: 104397 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060197CE RID: 104398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CB4")]
		private protected string topicId
		{
			[Token(Token = "0x60197CD")]
			[Address(RVA = "0x12312D0", Offset = "0x122FED0", VA = "0x1812312D0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60197CE")]
			[Address(RVA = "0x12313A0", Offset = "0x122FFA0", VA = "0x1812313A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x060197CF RID: 104399 RVA: 0x0009E4F0 File Offset: 0x0009C6F0
		// (set) Token: 0x060197D0 RID: 104400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CB5")]
		private protected bool isSingleMode
		{
			[Token(Token = "0x60197CF")]
			[Address(RVA = "0x12311C0", Offset = "0x122FDC0", VA = "0x1812311C0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60197D0")]
			[Address(RVA = "0x1231330", Offset = "0x122FF30", VA = "0x181231330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060197D1 RID: 104401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197D1")]
		[Address(RVA = "0x1230C00", Offset = "0x122F800", VA = "0x181230C00", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminMainModelProperty property)
		{
		}

		// Token: 0x060197D2 RID: 104402
		[Token(Token = "0x60197D2")]
		protected abstract void OnUpdate(SandboxV2AdminMainTabPanelUpdateCase updateCase);

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x060197D3 RID: 104403
		[Token(Token = "0x17003CB6")]
		public abstract SandboxV2AdminMainPanelType panelType { [Token(Token = "0x60197D3")] get; }

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x060197D4 RID: 104404
		[Token(Token = "0x17003CB7")]
		public abstract string topTitle { [Token(Token = "0x60197D4")] get; }

		// Token: 0x060197D5 RID: 104405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60197D5")]
		[Address(RVA = "0x1230BA0", Offset = "0x122F7A0", VA = "0x181230BA0", Slot = "11")]
		protected virtual Func<string, bool> OnGetActiveCheckFunc()
		{
			return null;
		}

		// Token: 0x060197D6 RID: 104406 RVA: 0x0009E508 File Offset: 0x0009C708
		[Token(Token = "0x60197D6")]
		[Address(RVA = "0x12309E0", Offset = "0x122F5E0", VA = "0x1812309E0")]
		public TabPanelConfig GetTabPanelConfig()
		{
			return default(TabPanelConfig);
		}

		// Token: 0x060197D7 RID: 104407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197D7")]
		[Address(RVA = "0x1230F30", Offset = "0x122FB30", VA = "0x181230F30")]
		public void TriggerExit()
		{
		}

		// Token: 0x060197D8 RID: 104408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197D8")]
		[Address(RVA = "0x1230FB0", Offset = "0x122FBB0", VA = "0x181230FB0")]
		public void TriggerHideProcess(Action done)
		{
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x060197D9 RID: 104409 RVA: 0x0009E520 File Offset: 0x0009C720
		[Token(Token = "0x17003CB8")]
		public bool isValid
		{
			[Token(Token = "0x60197D9")]
			[Address(RVA = "0x1231220", Offset = "0x122FE20", VA = "0x181231220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060197DA RID: 104410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60197DA")]
		[Address(RVA = "0x1230B00", Offset = "0x122F700", VA = "0x181230B00", Slot = "12")]
		public virtual IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetToDataListener()
		{
			return null;
		}

		// Token: 0x060197DB RID: 104411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60197DB")]
		[Address(RVA = "0x1230940", Offset = "0x122F540", VA = "0x181230940", Slot = "13")]
		public virtual IEnumerable<KeyValuePair<Type, Action<IStateBean>>> GetFromDataListener()
		{
			return null;
		}

		// Token: 0x060197DC RID: 104412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60197DC")]
		protected T GetInitParam<T>(bool notNull) where T : class, ISandboxV2AdminMainTabPanelInitParam, new()
		{
			return null;
		}

		// Token: 0x060197DD RID: 104413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197DD")]
		[Address(RVA = "0x1230ED0", Offset = "0x122FAD0", VA = "0x181230ED0", Slot = "14")]
		protected virtual void OnVisible(bool v)
		{
		}

		// Token: 0x060197DE RID: 104414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197DE")]
		[Address(RVA = "0x122EE70", Offset = "0x122DA70", VA = "0x18122EE70", Slot = "15")]
		protected virtual void OnHideProcess(Action done)
		{
		}

		// Token: 0x060197DF RID: 104415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197DF")]
		[Address(RVA = "0x1231040", Offset = "0x122FC40", VA = "0x181231040")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060197E0 RID: 104416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197E0")]
		[Address(RVA = "0x1231110", Offset = "0x122FD10", VA = "0x181231110")]
		protected SandboxV2AdminMainTabPanel()
		{
		}

		// Token: 0x0401FC4A RID: 130122
		[Token(Token = "0x401FC4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401FC4B RID: 130123
		[Token(Token = "0x401FC4B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _topIcon;

		// Token: 0x0401FC4C RID: 130124
		[Token(Token = "0x401FC4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _hideBottomGradient;

		// Token: 0x0401FC4D RID: 130125
		[Token(Token = "0x401FC4D")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x0401FC4E RID: 130126
		[Token(Token = "0x401FC4E")]
		[FieldOffset(Offset = "0x48")]
		private int m_resumeTick;

		// Token: 0x0401FC51 RID: 130129
		[Token(Token = "0x401FC51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401FC52 RID: 130130
		[Token(Token = "0x401FC52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0401FC53 RID: 130131
		[Token(Token = "0x401FC53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isSingleMode;

		// Token: 0x0401FC54 RID: 130132
		[Token(Token = "0x401FC54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isSingleMode;

		// Token: 0x0401FC55 RID: 130133
		[Token(Token = "0x401FC55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401FC56 RID: 130134
		[Token(Token = "0x401FC56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnGetActiveCheckFunc;

		// Token: 0x0401FC57 RID: 130135
		[Token(Token = "0x401FC57")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTabPanelConfig;

		// Token: 0x0401FC58 RID: 130136
		[Token(Token = "0x401FC58")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerExit;

		// Token: 0x0401FC59 RID: 130137
		[Token(Token = "0x401FC59")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TriggerHideProcess;

		// Token: 0x0401FC5A RID: 130138
		[Token(Token = "0x401FC5A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0401FC5B RID: 130139
		[Token(Token = "0x401FC5B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetToDataListener;

		// Token: 0x0401FC5C RID: 130140
		[Token(Token = "0x401FC5C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetFromDataListener;

		// Token: 0x0401FC5D RID: 130141
		[Token(Token = "0x401FC5D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetInitParam;

		// Token: 0x0401FC5E RID: 130142
		[Token(Token = "0x401FC5E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnVisible;

		// Token: 0x0401FC5F RID: 130143
		[Token(Token = "0x401FC5F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnHideProcess;

		// Token: 0x0401FC60 RID: 130144
		[Token(Token = "0x401FC60")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FC61 RID: 130145
		[Token(Token = "0x401FC61")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
