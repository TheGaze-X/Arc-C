using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006D03 RID: 27907
	[Token(Token = "0x2006D03")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public abstract class ActivityStageComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027C8F RID: 162959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C8F")]
		[Address(RVA = "0x22F32F0", Offset = "0x22F1EF0", VA = "0x1822F32F0")]
		public void ActivityLoaderOnlySetController(ActivityStageController controller)
		{
		}

		// Token: 0x06027C90 RID: 162960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C90")]
		[Address(RVA = "0x22F36E0", Offset = "0x22F22E0", VA = "0x1822F36E0")]
		public void TriggerLoaded()
		{
		}

		// Token: 0x06027C91 RID: 162961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C91")]
		[Address(RVA = "0x22F35E0", Offset = "0x22F21E0", VA = "0x1822F35E0")]
		public void TriggerBeforeUnload()
		{
		}

		// Token: 0x06027C92 RID: 162962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C92")]
		[Address(RVA = "0x22F3660", Offset = "0x22F2260", VA = "0x1822F3660")]
		public void TriggerBindToParent()
		{
		}

		// Token: 0x06027C93 RID: 162963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C93")]
		[Address(RVA = "0x22F3760", Offset = "0x22F2360", VA = "0x1822F3760")]
		public void TriggerPageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x17005E08 RID: 24072
		// (get) Token: 0x06027C94 RID: 162964 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027C95 RID: 162965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E08")]
		public ActivityStageController controller
		{
			[Token(Token = "0x6027C94")]
			[Address(RVA = "0x22F3890", Offset = "0x22F2490", VA = "0x1822F3890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027C95")]
			[Address(RVA = "0x22F38F0", Offset = "0x22F24F0", VA = "0x1822F38F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027C96 RID: 162966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C96")]
		[Address(RVA = "0x22F1320", Offset = "0x22EFF20", VA = "0x1822F1320", Slot = "4")]
		protected virtual void OnLoaded()
		{
		}

		// Token: 0x06027C97 RID: 162967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C97")]
		[Address(RVA = "0x22F2DE0", Offset = "0x22F19E0", VA = "0x1822F2DE0", Slot = "5")]
		protected virtual void BeforeUnload()
		{
		}

		// Token: 0x06027C98 RID: 162968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C98")]
		[Address(RVA = "0x22F34A0", Offset = "0x22F20A0", VA = "0x1822F34A0", Slot = "6")]
		protected virtual void OnBindToParent()
		{
		}

		// Token: 0x06027C99 RID: 162969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C99")]
		[Address(RVA = "0x22F3500", Offset = "0x22F2100", VA = "0x1822F3500", Slot = "7")]
		protected virtual void OnControllerBinded()
		{
		}

		// Token: 0x06027C9A RID: 162970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C9A")]
		[Address(RVA = "0x22F3410", Offset = "0x22F2010", VA = "0x1822F3410", Slot = "8")]
		public virtual IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x06027C9B RID: 162971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C9B")]
		[Address(RVA = "0x22F3560", Offset = "0x22F2160", VA = "0x1822F3560", Slot = "9")]
		protected virtual void OnPageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06027C9C RID: 162972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C9C")]
		[Address(RVA = "0x22F3830", Offset = "0x22F2430", VA = "0x1822F3830")]
		protected ActivityStageComponent()
		{
		}

		// Token: 0x040386CE RID: 231118
		[Token(Token = "0x40386CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ActivityLoaderOnlySetController;

		// Token: 0x040386CF RID: 231119
		[Token(Token = "0x40386CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TriggerLoaded;

		// Token: 0x040386D0 RID: 231120
		[Token(Token = "0x40386D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerBeforeUnload;

		// Token: 0x040386D1 RID: 231121
		[Token(Token = "0x40386D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerBindToParent;

		// Token: 0x040386D2 RID: 231122
		[Token(Token = "0x40386D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerPageResumed;

		// Token: 0x040386D3 RID: 231123
		[Token(Token = "0x40386D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040386D4 RID: 231124
		[Token(Token = "0x40386D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040386D5 RID: 231125
		[Token(Token = "0x40386D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x040386D6 RID: 231126
		[Token(Token = "0x40386D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_BeforeUnload;

		// Token: 0x040386D7 RID: 231127
		[Token(Token = "0x40386D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBindToParent;

		// Token: 0x040386D8 RID: 231128
		[Token(Token = "0x40386D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnControllerBinded;

		// Token: 0x040386D9 RID: 231129
		[Token(Token = "0x40386D9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x040386DA RID: 231130
		[Token(Token = "0x40386DA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnPageResumed;

		// Token: 0x040386DB RID: 231131
		[Token(Token = "0x40386DB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
