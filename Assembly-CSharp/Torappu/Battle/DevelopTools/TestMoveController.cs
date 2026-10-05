using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x02002891 RID: 10385
	[Token(Token = "0x2002891")]
	public class TestMoveController : MoveController
	{
		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x060114B5 RID: 70837 RVA: 0x0006A890 File Offset: 0x00068A90
		[Token(Token = "0x1700263D")]
		public override float moveSpeed
		{
			[Token(Token = "0x60114B5")]
			[Address(RVA = "0x932C70", Offset = "0x931870", VA = "0x180932C70", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060114B6 RID: 70838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114B6")]
		[Address(RVA = "0x932C00", Offset = "0x931800", VA = "0x180932C00")]
		public TestMoveController()
		{
		}

		// Token: 0x060114B7 RID: 70839 RVA: 0x0006A8A8 File Offset: 0x00068AA8
		[Token(Token = "0x60114B7")]
		[Address(RVA = "0x932BF0", Offset = "0x9317F0", VA = "0x180932BF0")]
		private float <>xLuaBaseProxy_get_moveSpeed()
		{
			return 0f;
		}

		// Token: 0x04013503 RID: 79107
		[Token(Token = "0x4013503")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _moveSpeed;

		// Token: 0x04013504 RID: 79108
		[Token(Token = "0x4013504")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moveSpeed;

		// Token: 0x04013505 RID: 79109
		[Token(Token = "0x4013505")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
