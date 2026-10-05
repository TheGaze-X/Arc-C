using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D15 RID: 15637
	[Token(Token = "0x2003D15")]
	public class TrainingCampPage : StateEnginePage
	{
		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x06018615 RID: 99861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018616 RID: 99862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A4F")]
		public TrainingCampUtil.JumpParam jumpParm
		{
			[Token(Token = "0x6018615")]
			[Address(RVA = "0x10D20B0", Offset = "0x10D0CB0", VA = "0x1810D20B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018616")]
			[Address(RVA = "0x10D2110", Offset = "0x10D0D10", VA = "0x1810D2110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018617 RID: 99863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018617")]
		[Address(RVA = "0x10D1DA0", Offset = "0x10D09A0", VA = "0x1810D1DA0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018618 RID: 99864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018618")]
		[Address(RVA = "0x10D2050", Offset = "0x10D0C50", VA = "0x1810D2050")]
		public TrainingCampPage()
		{
		}

		// Token: 0x0601861B RID: 99867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601861B")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401DD09 RID: 122121
		[Token(Token = "0x401DD09")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401DD0B RID: 122123
		[Token(Token = "0x401DD0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_jumpParm;

		// Token: 0x0401DD0C RID: 122124
		[Token(Token = "0x401DD0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_jumpParm;

		// Token: 0x0401DD0D RID: 122125
		[Token(Token = "0x401DD0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401DD0E RID: 122126
		[Token(Token = "0x401DD0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
