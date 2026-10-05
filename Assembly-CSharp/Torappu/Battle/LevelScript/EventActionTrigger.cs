using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002832 RID: 10290
	[Token(Token = "0x2002832")]
	public class EventActionTrigger : ActionExecutor
	{
		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x0601122F RID: 70191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025C4")]
		public string eventKey
		{
			[Token(Token = "0x601122F")]
			[Address(RVA = "0x90C820", Offset = "0x90B420", VA = "0x18090C820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x06011230 RID: 70192 RVA: 0x00069870 File Offset: 0x00067A70
		[Token(Token = "0x170025C5")]
		public uint eventKeyEnum
		{
			[Token(Token = "0x6011230")]
			[Address(RVA = "0x90C7D0", Offset = "0x90B3D0", VA = "0x18090C7D0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06011231 RID: 70193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011231")]
		[Address(RVA = "0x90C330", Offset = "0x90AF30", VA = "0x18090C330")]
		public static EventActionTrigger NewEventActionTrigger()
		{
			return null;
		}

		// Token: 0x06011232 RID: 70194 RVA: 0x00069888 File Offset: 0x00067A88
		[Token(Token = "0x6011232")]
		[Address(RVA = "0x90C2F0", Offset = "0x90AEF0", VA = "0x18090C2F0")]
		public bool CheckCanInvoke(string eventKey)
		{
			return default(bool);
		}

		// Token: 0x06011233 RID: 70195 RVA: 0x000698A0 File Offset: 0x00067AA0
		[Token(Token = "0x6011233")]
		[Address(RVA = "0x90C280", Offset = "0x90AE80", VA = "0x18090C280")]
		public bool CheckCanInvoke(uint eventKeyEnum)
		{
			return default(bool);
		}

		// Token: 0x06011234 RID: 70196 RVA: 0x000698B8 File Offset: 0x00067AB8
		[Token(Token = "0x6011234")]
		[Address(RVA = "0x90C6D0", Offset = "0x90B2D0", VA = "0x18090C6D0")]
		public bool TryInvoke(string eventKey, EventParams eventParams)
		{
			return default(bool);
		}

		// Token: 0x06011235 RID: 70197 RVA: 0x000698D0 File Offset: 0x00067AD0
		[Token(Token = "0x6011235")]
		[Address(RVA = "0x90C630", Offset = "0x90B230", VA = "0x18090C630")]
		public bool TryInvoke(uint eventKeyEnum, EventParams eventParams)
		{
			return default(bool);
		}

		// Token: 0x06011236 RID: 70198 RVA: 0x000698E8 File Offset: 0x00067AE8
		[Token(Token = "0x6011236")]
		[Address(RVA = "0x90C530", Offset = "0x90B130", VA = "0x18090C530")]
		public static bool TryCreateNew(ActionContext actionContext, ActionHeader header, out EventActionTrigger result)
		{
			return default(bool);
		}

		// Token: 0x06011237 RID: 70199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011237")]
		[Address(RVA = "0x90C4B0", Offset = "0x90B0B0", VA = "0x18090C4B0", Slot = "9")]
		public override void Recycle()
		{
		}

		// Token: 0x06011238 RID: 70200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011238")]
		[Address(RVA = "0x90C3B0", Offset = "0x90AFB0", VA = "0x18090C3B0", Slot = "7")]
		public override void OnAllocate()
		{
		}

		// Token: 0x06011239 RID: 70201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011239")]
		[Address(RVA = "0x90C480", Offset = "0x90B080", VA = "0x18090C480", Slot = "8")]
		public override void OnRecycle()
		{
		}

		// Token: 0x0601123A RID: 70202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601123A")]
		[Address(RVA = "0x90C760", Offset = "0x90B360", VA = "0x18090C760")]
		private void _Clear()
		{
		}

		// Token: 0x0601123B RID: 70203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601123B")]
		[Address(RVA = "0x90C780", Offset = "0x90B380", VA = "0x18090C780")]
		public EventActionTrigger()
		{
		}

		// Token: 0x0401331E RID: 78622
		[Token(Token = "0x401331E")]
		[FieldOffset(Offset = "0xA8")]
		public ActionHeader header;
	}
}
