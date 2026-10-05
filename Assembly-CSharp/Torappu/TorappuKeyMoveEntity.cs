using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	public class TorappuKeyMoveEntity : IHotfixable
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x0002E710 File Offset: 0x0002C910
		[Token(Token = "0x17000250")]
		public Vector2 moveDir
		{
			[Token(Token = "0x6004FC4")]
			[Address(RVA = "0x1B02560", Offset = "0x1B01160", VA = "0x181B02560")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x0002E728 File Offset: 0x0002C928
		[Token(Token = "0x17000251")]
		public bool isMoving
		{
			[Token(Token = "0x6004FC5")]
			[Address(RVA = "0x1B02500", Offset = "0x1B01100", VA = "0x181B02500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x1B02140", Offset = "0x1B00D40", VA = "0x181B02140")]
		public void Process()
		{
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x1B01D00", Offset = "0x1B00900", VA = "0x181B01D00")]
		public void OnBind(IKeyMoveHandler holder, Func<bool> checkAvail)
		{
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x1B02400", Offset = "0x1B01000", VA = "0x181B02400")]
		public void UnBind()
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x1B024A0", Offset = "0x1B010A0", VA = "0x181B024A0")]
		public TorappuKeyMoveEntity()
		{
		}

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0x10")]
		public bool isActive;

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x11")]
		private bool m_isAvail;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 m_moveDir;

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_isMoving;

		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x20")]
		private int m_cacheInstId;

		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x28")]
		private IKeyMoveHandler m_keyMoveHandler;

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInLeft;

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isInRight;

		// Token: 0x04001465 RID: 5221
		[Token(Token = "0x4001465")]
		[FieldOffset(Offset = "0x32")]
		private bool m_inUp;

		// Token: 0x04001466 RID: 5222
		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x33")]
		private bool m_isDown;

		// Token: 0x04001467 RID: 5223
		[Token(Token = "0x4001467")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moveDir;

		// Token: 0x04001468 RID: 5224
		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMoving;

		// Token: 0x04001469 RID: 5225
		[Token(Token = "0x4001469")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Process;

		// Token: 0x0400146A RID: 5226
		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBind;

		// Token: 0x0400146B RID: 5227
		[Token(Token = "0x400146B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnBind;

		// Token: 0x0400146C RID: 5228
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
