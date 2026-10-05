using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A68 RID: 31336
	[Token(Token = "0x2007A68")]
	public class Act12sideUISpineCharController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BE31 RID: 179761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE31")]
		[Address(RVA = "0x27C8CE0", Offset = "0x27C78E0", VA = "0x1827C8CE0")]
		public void SetAnimation(string animation)
		{
		}

		// Token: 0x0602BE32 RID: 179762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE32")]
		[Address(RVA = "0x27C8DC0", Offset = "0x27C79C0", VA = "0x1827C8DC0")]
		public Act12sideUISpineCharController()
		{
		}

		// Token: 0x0403F8F8 RID: 260344
		[Token(Token = "0x403F8F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkeletonGraphic _skeleton;

		// Token: 0x0403F8F9 RID: 260345
		[Token(Token = "0x403F8F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetAnimation;

		// Token: 0x0403F8FA RID: 260346
		[Token(Token = "0x403F8FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
