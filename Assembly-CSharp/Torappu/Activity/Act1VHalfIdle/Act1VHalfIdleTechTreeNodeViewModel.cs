using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200780D RID: 30733
	[Token(Token = "0x200780D")]
	public class Act1VHalfIdleTechTreeNodeViewModel : IHotfixable
	{
		// Token: 0x170064E5 RID: 25829
		// (get) Token: 0x0602B1DD RID: 176605 RVA: 0x000DAE98 File Offset: 0x000D9098
		[Token(Token = "0x170064E5")]
		public bool canUnlock
		{
			[Token(Token = "0x602B1DD")]
			[Address(RVA = "0x26FD7D0", Offset = "0x26FC3D0", VA = "0x1826FD7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170064E6 RID: 25830
		// (get) Token: 0x0602B1DE RID: 176606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064E6")]
		public string nodeId
		{
			[Token(Token = "0x602B1DE")]
			[Address(RVA = "0x26FD840", Offset = "0x26FC440", VA = "0x1826FD840")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B1DF RID: 176607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1DF")]
		[Address(RVA = "0x26FD770", Offset = "0x26FC370", VA = "0x1826FD770")]
		public Act1VHalfIdleTechTreeNodeViewModel()
		{
		}

		// Token: 0x0403E4F5 RID: 255221
		[Token(Token = "0x403E4F5")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403E4F6 RID: 255222
		[Token(Token = "0x403E4F6")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 pos;

		// Token: 0x0403E4F7 RID: 255223
		[Token(Token = "0x403E4F7")]
		[FieldOffset(Offset = "0x20")]
		public bool isUnlock;

		// Token: 0x0403E4F8 RID: 255224
		[Token(Token = "0x403E4F8")]
		[FieldOffset(Offset = "0x21")]
		public bool unlockCostEnough;

		// Token: 0x0403E4F9 RID: 255225
		[Token(Token = "0x403E4F9")]
		[FieldOffset(Offset = "0x22")]
		public bool prevAllUnlock;

		// Token: 0x0403E4FA RID: 255226
		[Token(Token = "0x403E4FA")]
		[FieldOffset(Offset = "0x28")]
		public Act1VHalfIdleTechTreeData nodeData;

		// Token: 0x0403E4FB RID: 255227
		[Token(Token = "0x403E4FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canUnlock;

		// Token: 0x0403E4FC RID: 255228
		[Token(Token = "0x403E4FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x0403E4FD RID: 255229
		[Token(Token = "0x403E4FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
