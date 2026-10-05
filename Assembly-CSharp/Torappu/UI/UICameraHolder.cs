using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039D7 RID: 14807
	[Token(Token = "0x20039D7")]
	public class UICameraHolder : SingletonMonoBehaviour<UICameraHolder>, ISingletonNotAutoCreate
	{
		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x06017636 RID: 95798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003808")]
		public static Camera[] cameras
		{
			[Token(Token = "0x6017636")]
			[Address(RVA = "0xFBCB70", Offset = "0xFBB770", VA = "0x180FBCB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017637 RID: 95799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017637")]
		[Address(RVA = "0xFBCB00", Offset = "0xFBB700", VA = "0x180FBCB00")]
		public UICameraHolder()
		{
		}

		// Token: 0x0401C3EF RID: 115695
		[Token(Token = "0x401C3EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera[] _cameras;

		// Token: 0x0401C3F0 RID: 115696
		[Token(Token = "0x401C3F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameras;

		// Token: 0x0401C3F1 RID: 115697
		[Token(Token = "0x401C3F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
