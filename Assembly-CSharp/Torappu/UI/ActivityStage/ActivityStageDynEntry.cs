using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006D1B RID: 27931
	[Token(Token = "0x2006D1B")]
	[RequireComponent(typeof(ActivityStageSingleComponent))]
	public class ActivityStageDynEntry : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E3C RID: 24124
		// (get) Token: 0x06027D55 RID: 163157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E3C")]
		public List<ActivityStageComponent> components
		{
			[Token(Token = "0x6027D55")]
			[Address(RVA = "0x22F6330", Offset = "0x22F4F30", VA = "0x1822F6330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E3D RID: 24125
		// (get) Token: 0x06027D56 RID: 163158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E3D")]
		public ActivityStageSingleComponent entry
		{
			[Token(Token = "0x6027D56")]
			[Address(RVA = "0x22F6390", Offset = "0x22F4F90", VA = "0x1822F6390")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027D57 RID: 163159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D57")]
		[Address(RVA = "0x22F62D0", Offset = "0x22F4ED0", VA = "0x1822F62D0")]
		public ActivityStageDynEntry()
		{
		}

		// Token: 0x0403877A RID: 231290
		[Token(Token = "0x403877A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private List<ActivityStageComponent> _components;

		// Token: 0x0403877B RID: 231291
		[Token(Token = "0x403877B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityStageSingleComponent _entry;

		// Token: 0x0403877C RID: 231292
		[Token(Token = "0x403877C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_components;

		// Token: 0x0403877D RID: 231293
		[Token(Token = "0x403877D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_entry;

		// Token: 0x0403877E RID: 231294
		[Token(Token = "0x403877E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
