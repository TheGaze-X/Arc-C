using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007662 RID: 30306
	[Token(Token = "0x2007662")]
	public class Act20sideCartDetailState : State
	{
		// Token: 0x0602AA01 RID: 174593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA01")]
		[Address(RVA = "0x2654A80", Offset = "0x2653680", VA = "0x182654A80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602AA02 RID: 174594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA02")]
		[Address(RVA = "0x2655420", Offset = "0x2654020", VA = "0x182655420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA03 RID: 174595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA03")]
		[Address(RVA = "0x2655550", Offset = "0x2654150", VA = "0x182655550")]
		private void _RenderComp(Act20sideDetailPage.Param param, CartComponents.CartAccessoryPos pos, Act20sideCarDetailCompObj compObj, Dictionary<string, PlayerCartInfo.CompInfo> accessories)
		{
		}

		// Token: 0x0602AA04 RID: 174596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA04")]
		[Address(RVA = "0x2654AE0", Offset = "0x26536E0", VA = "0x182654AE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602AA05 RID: 174597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA05")]
		[Address(RVA = "0x2654FD0", Offset = "0x2653BD0", VA = "0x182654FD0")]
		private void _ApplyCharInfo(Act20sideDetailPage.Param param)
		{
		}

		// Token: 0x0602AA06 RID: 174598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA06")]
		[Address(RVA = "0x2654DE0", Offset = "0x26539E0", VA = "0x182654DE0")]
		private void _ApplyAvatar(AvatarInfo avatarInfo)
		{
		}

		// Token: 0x0602AA07 RID: 174599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA07")]
		[Address(RVA = "0x26556D0", Offset = "0x26542D0", VA = "0x1826556D0")]
		public Act20sideCartDetailState()
		{
		}

		// Token: 0x0602AA08 RID: 174600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA08")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403D623 RID: 251427
		[Token(Token = "0x403D623")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act20sideCarObject _carObject;

		// Token: 0x0403D624 RID: 251428
		[Token(Token = "0x403D624")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403D625 RID: 251429
		[Token(Token = "0x403D625")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act20sideCarDetailCompObj _trunk01;

		// Token: 0x0403D626 RID: 251430
		[Token(Token = "0x403D626")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act20sideCarDetailCompObj _trunk02;

		// Token: 0x0403D627 RID: 251431
		[Token(Token = "0x403D627")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act20sideCarDetailCompObj _os01;

		// Token: 0x0403D628 RID: 251432
		[Token(Token = "0x403D628")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act20sideCarDetailCompObj _os02;

		// Token: 0x0403D629 RID: 251433
		[Token(Token = "0x403D629")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act20sideCarDetailCompObj _headStock;

		// Token: 0x0403D62A RID: 251434
		[Token(Token = "0x403D62A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act20sideCarDetailCompObj _roof;

		// Token: 0x0403D62B RID: 251435
		[Token(Token = "0x403D62B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _cartScaler;

		// Token: 0x0403D62C RID: 251436
		[Token(Token = "0x403D62C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Char Info")]
		private Transform _avatarContainer;

		// Token: 0x0403D62D RID: 251437
		[Token(Token = "0x403D62D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Char Info")]
		private GameObject _panelLevel;

		// Token: 0x0403D62E RID: 251438
		[Token(Token = "0x403D62E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Char Info")]
		private Text _levelText;

		// Token: 0x0403D62F RID: 251439
		[Token(Token = "0x403D62F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Char Info")]
		private UIAtlasImage _npcIcon;

		// Token: 0x0403D630 RID: 251440
		[Token(Token = "0x403D630")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Char Info")]
		private Text _name;

		// Token: 0x0403D631 RID: 251441
		[Token(Token = "0x403D631")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Char Info")]
		private Text _nickNumber;

		// Token: 0x0403D632 RID: 251442
		[Token(Token = "0x403D632")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Char Info")]
		private float _avatarViewScale;

		// Token: 0x0403D633 RID: 251443
		[Token(Token = "0x403D633")]
		[FieldOffset(Offset = "0xD0")]
		private Act20sideCarObject m_carObject;

		// Token: 0x0403D634 RID: 251444
		[Token(Token = "0x403D634")]
		[FieldOffset(Offset = "0xD8")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0403D635 RID: 251445
		[Token(Token = "0x403D635")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x0403D636 RID: 251446
		[Token(Token = "0x403D636")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D637 RID: 251447
		[Token(Token = "0x403D637")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D638 RID: 251448
		[Token(Token = "0x403D638")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderComp;

		// Token: 0x0403D639 RID: 251449
		[Token(Token = "0x403D639")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D63A RID: 251450
		[Token(Token = "0x403D63A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyCharInfo;

		// Token: 0x0403D63B RID: 251451
		[Token(Token = "0x403D63B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyAvatar;

		// Token: 0x0403D63C RID: 251452
		[Token(Token = "0x403D63C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
