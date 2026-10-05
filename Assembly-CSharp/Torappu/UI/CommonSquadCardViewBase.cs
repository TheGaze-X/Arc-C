using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035B7 RID: 13751
	[Token(Token = "0x20035B7")]
	public abstract class CommonSquadCardViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x06015E11 RID: 89617 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015E12 RID: 89618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003480")]
		public Action<CommonSquadCardViewBase.Options> onClick
		{
			[Token(Token = "0x6015E11")]
			[Address(RVA = "0xE61CC0", Offset = "0xE608C0", VA = "0x180E61CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015E12")]
			[Address(RVA = "0xE61E20", Offset = "0xE60A20", VA = "0x180E61E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x06015E13 RID: 89619 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015E14 RID: 89620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003481")]
		public CommonCharCardView cardRes
		{
			[Token(Token = "0x6015E13")]
			[Address(RVA = "0xE61C60", Offset = "0xE60860", VA = "0x180E61C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015E14")]
			[Address(RVA = "0xE61DA0", Offset = "0xE609A0", VA = "0x180E61DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x06015E15 RID: 89621 RVA: 0x0008E8F0 File Offset: 0x0008CAF0
		// (set) Token: 0x06015E16 RID: 89622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003482")]
		protected CommonSquadCardViewBase.Options optionsCache
		{
			[Token(Token = "0x6015E15")]
			[Address(RVA = "0xE61D20", Offset = "0xE60920", VA = "0x180E61D20")]
			[CompilerGenerated]
			get
			{
				return default(CommonSquadCardViewBase.Options);
			}
			[Token(Token = "0x6015E16")]
			[Address(RVA = "0xE61EA0", Offset = "0xE60AA0", VA = "0x180E61EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06015E17 RID: 89623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E17")]
		[Address(RVA = "0xE61AF0", Offset = "0xE606F0", VA = "0x180E61AF0", Slot = "4")]
		public virtual void RenderCard(CommonSquadCardViewBase.Options input)
		{
		}

		// Token: 0x06015E18 RID: 89624
		[Token(Token = "0x6015E18")]
		protected abstract void CustomRenderCard(CommonSquadCardViewBase.Options input);

		// Token: 0x06015E19 RID: 89625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E19")]
		[Address(RVA = "0xE619D0", Offset = "0xE605D0", VA = "0x180E619D0", Slot = "6")]
		protected virtual void InvokeOnClick()
		{
		}

		// Token: 0x06015E1A RID: 89626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E1A")]
		[Address(RVA = "0xE61950", Offset = "0xE60550", VA = "0x180E61950")]
		public void EventOnClick()
		{
		}

		// Token: 0x06015E1B RID: 89627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E1B")]
		[Address(RVA = "0xE61C00", Offset = "0xE60800", VA = "0x180E61C00")]
		protected CommonSquadCardViewBase()
		{
		}

		// Token: 0x0401A4FF RID: 107775
		[Token(Token = "0x401A4FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0401A500 RID: 107776
		[Token(Token = "0x401A500")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401A501 RID: 107777
		[Token(Token = "0x401A501")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardRes;

		// Token: 0x0401A502 RID: 107778
		[Token(Token = "0x401A502")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_cardRes;

		// Token: 0x0401A503 RID: 107779
		[Token(Token = "0x401A503")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_optionsCache;

		// Token: 0x0401A504 RID: 107780
		[Token(Token = "0x401A504")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_optionsCache;

		// Token: 0x0401A505 RID: 107781
		[Token(Token = "0x401A505")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0401A506 RID: 107782
		[Token(Token = "0x401A506")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InvokeOnClick;

		// Token: 0x0401A507 RID: 107783
		[Token(Token = "0x401A507")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401A508 RID: 107784
		[Token(Token = "0x401A508")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035B8 RID: 13752
		[Token(Token = "0x20035B8")]
		public struct Options
		{
			// Token: 0x17003483 RID: 13443
			// (get) Token: 0x06015E1C RID: 89628 RVA: 0x0008E908 File Offset: 0x0008CB08
			[Token(Token = "0x17003483")]
			public bool isEmpty
			{
				[Token(Token = "0x6015E1C")]
				[Address(RVA = "0xE736F0", Offset = "0xE722F0", VA = "0x180E736F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0401A509 RID: 107785
			[Token(Token = "0x401A509")]
			[FieldOffset(Offset = "0x0")]
			public bool isLocked;

			// Token: 0x0401A50A RID: 107786
			[Token(Token = "0x401A50A")]
			[FieldOffset(Offset = "0x4")]
			public int index;

			// Token: 0x0401A50B RID: 107787
			[Token(Token = "0x401A50B")]
			[FieldOffset(Offset = "0x8")]
			public ICommonSquadChar member;
		}
	}
}
