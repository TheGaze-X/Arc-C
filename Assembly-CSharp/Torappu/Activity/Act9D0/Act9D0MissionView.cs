using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007173 RID: 29043
	[Token(Token = "0x2007173")]
	public class Act9D0MissionView : Act9D0MissionBaseView
	{
		// Token: 0x060293B0 RID: 168880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B0")]
		[Address(RVA = "0x249D2D0", Offset = "0x249BED0", VA = "0x18249D2D0", Slot = "4")]
		public override void Render(Act9D0MissionStateBean stateBean)
		{
		}

		// Token: 0x060293B1 RID: 168881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293B1")]
		[Address(RVA = "0x249D560", Offset = "0x249C160", VA = "0x18249D560")]
		public Act9D0MissionView()
		{
		}

		// Token: 0x0403AE0E RID: 241166
		[Token(Token = "0x403AE0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403AE0F RID: 241167
		[Token(Token = "0x403AE0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act9D0MissionGroupAdapter _missionGroupAdapter;

		// Token: 0x0403AE10 RID: 241168
		[Token(Token = "0x403AE10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCanClaimAll;

		// Token: 0x0403AE11 RID: 241169
		[Token(Token = "0x403AE11")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objCantClaimAll;

		// Token: 0x0403AE12 RID: 241170
		[Token(Token = "0x403AE12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE13 RID: 241171
		[Token(Token = "0x403AE13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
