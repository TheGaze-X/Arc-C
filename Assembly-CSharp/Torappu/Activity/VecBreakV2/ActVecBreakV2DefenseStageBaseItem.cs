using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E0C RID: 28172
	[Token(Token = "0x2006E0C")]
	public abstract class ActVecBreakV2DefenseStageBaseItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x060281B4 RID: 164276 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060281B5 RID: 164277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ED5")]
		public Action<string> onClick
		{
			[Token(Token = "0x60281B4")]
			[Address(RVA = "0x23643A0", Offset = "0x2362FA0", VA = "0x1823643A0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60281B5")]
			[Address(RVA = "0x2364400", Offset = "0x2363000", VA = "0x182364400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060281B6 RID: 164278
		[Token(Token = "0x60281B6")]
		public abstract void Render(ActVecBreakV2DefenseStageBaseItem.InputParam inputParam);

		// Token: 0x060281B7 RID: 164279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60281B7")]
		[Address(RVA = "0x2364340", Offset = "0x2362F40", VA = "0x182364340")]
		protected ActVecBreakV2DefenseStageBaseItem()
		{
		}

		// Token: 0x04038E90 RID: 233104
		[Token(Token = "0x4038E90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x04038E91 RID: 233105
		[Token(Token = "0x4038E91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x04038E92 RID: 233106
		[Token(Token = "0x4038E92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E0D RID: 28173
		[Token(Token = "0x2006E0D")]
		public struct InputParam
		{
			// Token: 0x04038E93 RID: 233107
			[Token(Token = "0x4038E93")]
			[FieldOffset(Offset = "0x0")]
			public ActVecBreakV2DefenseStageBuffItemModel buffItemModel;

			// Token: 0x04038E94 RID: 233108
			[Token(Token = "0x4038E94")]
			[FieldOffset(Offset = "0x8")]
			public ActVecBreakV2DefenseStageDetailItemModel detailItemModel;

			// Token: 0x04038E95 RID: 233109
			[Token(Token = "0x4038E95")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelected;

			// Token: 0x04038E96 RID: 233110
			[Token(Token = "0x4038E96")]
			[FieldOffset(Offset = "0x18")]
			public long tsNow;

			// Token: 0x04038E97 RID: 233111
			[Token(Token = "0x4038E97")]
			[FieldOffset(Offset = "0x20")]
			public bool showDivLine;

			// Token: 0x04038E98 RID: 233112
			[Token(Token = "0x4038E98")]
			[FieldOffset(Offset = "0x21")]
			public bool useSelectPanel;

			// Token: 0x04038E99 RID: 233113
			[Token(Token = "0x4038E99")]
			[FieldOffset(Offset = "0x24")]
			public ActVecBreakV2DefenseStageBaseItem.BackgroundType backgroundType;
		}

		// Token: 0x02006E0E RID: 28174
		[Token(Token = "0x2006E0E")]
		public enum BackgroundType
		{
			// Token: 0x04038E9B RID: 233115
			[Token(Token = "0x4038E9B")]
			SINGLE,
			// Token: 0x04038E9C RID: 233116
			[Token(Token = "0x4038E9C")]
			GROUP_LEFT,
			// Token: 0x04038E9D RID: 233117
			[Token(Token = "0x4038E9D")]
			GROUP_MIDDLE,
			// Token: 0x04038E9E RID: 233118
			[Token(Token = "0x4038E9E")]
			GROUP_RIGHT
		}
	}
}
