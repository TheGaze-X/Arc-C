using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003673 RID: 13939
	[Token(Token = "0x2003673")]
	public class StateEnginePage : UIPage, StateEngine.IMaintainer
	{
		// Token: 0x060162DF RID: 90847 RVA: 0x0008FE68 File Offset: 0x0008E068
		[Token(Token = "0x60162DF")]
		[Address(RVA = "0xE98190", Offset = "0xE96D90", VA = "0x180E98190")]
		public bool IsStateEngineTransiting()
		{
			return default(bool);
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x060162E0 RID: 90848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003546")]
		protected StateEngine stateEngine
		{
			[Token(Token = "0x60162E0")]
			[Address(RVA = "0xE98950", Offset = "0xE97550", VA = "0x180E98950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060162E1 RID: 90849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162E1")]
		[Address(RVA = "0xE98370", Offset = "0xE96F70", VA = "0x180E98370", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x060162E2 RID: 90850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162E2")]
		[Address(RVA = "0xE98450", Offset = "0xE97050", VA = "0x180E98450", Slot = "14")]
		protected override void OnStop()
		{
		}

		// Token: 0x060162E3 RID: 90851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162E3")]
		[Address(RVA = "0xE98700", Offset = "0xE97300", VA = "0x180E98700", Slot = "24")]
		public LatchUtils.InvokeWhenUnlock StartStateEngine()
		{
			return null;
		}

		// Token: 0x060162E4 RID: 90852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162E4")]
		[Address(RVA = "0xE97F40", Offset = "0xE96B40", VA = "0x180E97F40", Slot = "25")]
		protected virtual IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060162E5 RID: 90853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162E5")]
		[Address(RVA = "0xE97E60", Offset = "0xE96A60", VA = "0x180E97E60", Slot = "26")]
		protected virtual IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060162E6 RID: 90854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162E6")]
		[Address(RVA = "0xE980E0", Offset = "0xE96CE0", VA = "0x180E980E0", Slot = "27")]
		protected virtual IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x060162E7 RID: 90855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162E7")]
		[Address(RVA = "0xE983F0", Offset = "0xE96FF0", VA = "0x180E983F0", Slot = "28")]
		protected virtual void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x060162E8 RID: 90856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003547")]
		protected new StateEnginePage.Plugin plugin
		{
			[Token(Token = "0x60162E8")]
			[Address(RVA = "0xE98870", Offset = "0xE97470", VA = "0x180E98870")]
			get
			{
				return null;
			}
		}

		// Token: 0x060162E9 RID: 90857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162E9")]
		[Address(RVA = "0xE98580", Offset = "0xE97180", VA = "0x180E98580", Slot = "11")]
		protected override IEnumerator ResetForVirtualStackCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060162EA RID: 90858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162EA")]
		[Address(RVA = "0xE98640", Offset = "0xE97240", VA = "0x180E98640", Slot = "12")]
		public sealed override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060162EB RID: 90859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162EB")]
		[Address(RVA = "0xE98000", Offset = "0xE96C00", VA = "0x180E98000", Slot = "13")]
		protected sealed override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060162EC RID: 90860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162EC")]
		[Address(RVA = "0xE98290", Offset = "0xE96E90", VA = "0x180E98290", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060162ED RID: 90861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162ED")]
		[Address(RVA = "0xE987C0", Offset = "0xE973C0", VA = "0x180E987C0")]
		public StateEnginePage()
		{
		}

		// Token: 0x060162EE RID: 90862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162EE")]
		[Address(RVA = "0xE98780", Offset = "0xE97380", VA = "0x180E98780")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x060162EF RID: 90863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162EF")]
		[Address(RVA = "0xE98790", Offset = "0xE97390", VA = "0x180E98790")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x060162F0 RID: 90864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162F0")]
		[Address(RVA = "0xE987A0", Offset = "0xE973A0", VA = "0x180E987A0")]
		private IEnumerator <>xLuaBaseProxy_ResetForVirtualStackCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x060162F1 RID: 90865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162F1")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x060162F2 RID: 90866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60162F2")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x060162F3 RID: 90867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60162F3")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401AA85 RID: 109189
		[Token(Token = "0x401AA85")]
		[FieldOffset(Offset = "0xD8")]
		private StateEngine m_stateEngine;

		// Token: 0x0401AA86 RID: 109190
		[Token(Token = "0x401AA86")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_createFlag;

		// Token: 0x0401AA87 RID: 109191
		[Token(Token = "0x401AA87")]
		[FieldOffset(Offset = "0xE8")]
		private LatchUtils.InvokeWhenUnlock m_startStateEngine;

		// Token: 0x0401AA88 RID: 109192
		[Token(Token = "0x401AA88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsStateEngineTransiting;

		// Token: 0x0401AA89 RID: 109193
		[Token(Token = "0x401AA89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stateEngine;

		// Token: 0x0401AA8A RID: 109194
		[Token(Token = "0x401AA8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401AA8B RID: 109195
		[Token(Token = "0x401AA8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0401AA8C RID: 109196
		[Token(Token = "0x401AA8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartStateEngine;

		// Token: 0x0401AA8D RID: 109197
		[Token(Token = "0x401AA8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0401AA8E RID: 109198
		[Token(Token = "0x401AA8E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0401AA8F RID: 109199
		[Token(Token = "0x401AA8F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0401AA90 RID: 109200
		[Token(Token = "0x401AA90")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0401AA91 RID: 109201
		[Token(Token = "0x401AA91")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0401AA92 RID: 109202
		[Token(Token = "0x401AA92")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ResetForVirtualStackCoroutine;

		// Token: 0x0401AA93 RID: 109203
		[Token(Token = "0x401AA93")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401AA94 RID: 109204
		[Token(Token = "0x401AA94")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401AA95 RID: 109205
		[Token(Token = "0x401AA95")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401AA96 RID: 109206
		[Token(Token = "0x401AA96")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003674 RID: 13940
		[Token(Token = "0x2003674")]
		public new class Plugin : UIPage.Plugin
		{
			// Token: 0x17003548 RID: 13640
			// (get) Token: 0x060162F4 RID: 90868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003548")]
			protected new StateEnginePage page
			{
				[Token(Token = "0x60162F4")]
				[Address(RVA = "0xE93C50", Offset = "0xE92850", VA = "0x180E93C50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17003549 RID: 13641
			// (get) Token: 0x060162F5 RID: 90869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17003549")]
			protected IStateEngine stateEngine
			{
				[Token(Token = "0x60162F5")]
				[Address(RVA = "0xE93D00", Offset = "0xE92900", VA = "0x180E93D00")]
				get
				{
					return null;
				}
			}

			// Token: 0x060162F6 RID: 90870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162F6")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "4")]
			public override void BindPage(UIPage context)
			{
			}

			// Token: 0x060162F7 RID: 90871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60162F7")]
			[Address(RVA = "0xE93BC0", Offset = "0xE927C0", VA = "0x180E93BC0", Slot = "12")]
			public virtual IEnumerator OverrideEffectsOnShow(Func<bool, IEnumerator> effectOnShow, bool isFromStack)
			{
				return null;
			}

			// Token: 0x060162F8 RID: 90872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60162F8")]
			[Address(RVA = "0xE93B20", Offset = "0xE92720", VA = "0x180E93B20", Slot = "13")]
			public virtual IEnumerator OverrideEffectsOnHide(Func<bool, bool, IEnumerator> effectOnHide, bool isIntoStack, bool isRemoveVirtualTop)
			{
				return null;
			}

			// Token: 0x060162F9 RID: 90873 RVA: 0x0008FE80 File Offset: 0x0008E080
			[Token(Token = "0x60162F9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "14")]
			public virtual bool OverrideStateEngineReady(Action<bool> onStateEngineReady, bool isFromStack)
			{
				return default(bool);
			}

			// Token: 0x060162FA RID: 90874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60162FA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Plugin()
			{
			}
		}
	}
}
