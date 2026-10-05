using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AEC RID: 15084
	[Token(Token = "0x2003AEC")]
	public class PlayerAvatarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x06017C75 RID: 97397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038F5")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x6017C75")]
			[Address(RVA = "0x1003CB0", Offset = "0x10028B0", VA = "0x181003CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017C76 RID: 97398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C76")]
		[Address(RVA = "0x1003010", Offset = "0x1001C10", VA = "0x181003010")]
		public void Render(AvatarInfo avatarInfo, [Optional] ILoadAsset spriteLoader)
		{
		}

		// Token: 0x06017C77 RID: 97399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C77")]
		[Address(RVA = "0x1002D50", Offset = "0x1001950", VA = "0x181002D50")]
		public void Render(AvatarInfo avatarInfo, PlayerAvatarView.Params param, [Optional] ILoadAsset spriteLoader)
		{
		}

		// Token: 0x06017C78 RID: 97400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C78")]
		[Address(RVA = "0x1002BC0", Offset = "0x10017C0", VA = "0x181002BC0")]
		public void Render(PlayerAvatarQuery query, [Optional] ILoadAsset loader)
		{
		}

		// Token: 0x06017C79 RID: 97401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C79")]
		[Address(RVA = "0x10029F0", Offset = "0x10015F0", VA = "0x1810029F0")]
		public void RenderByPlayerAvatarQuery(PlayerAvatarQuery query, [Optional] ILoadAsset loader)
		{
		}

		// Token: 0x06017C7A RID: 97402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C7A")]
		[Address(RVA = "0x1002F20", Offset = "0x1001B20", VA = "0x181002F20")]
		public void Render(PlayerAvatarQuery query, PlayerAvatarView.Params param, [Optional] ILoadAsset loader)
		{
		}

		// Token: 0x06017C7B RID: 97403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C7B")]
		[Address(RVA = "0x1003600", Offset = "0x1002200", VA = "0x181003600")]
		private void _Render(PlayerAvatarView.Params param, ILoadAsset spriteLoader)
		{
		}

		// Token: 0x06017C7C RID: 97404 RVA: 0x000981D8 File Offset: 0x000963D8
		[Token(Token = "0x6017C7C")]
		[Address(RVA = "0x1003840", Offset = "0x1002440", VA = "0x181003840")]
		private bool _TryLoadDynAvatar(string dynAvatarId)
		{
			return default(bool);
		}

		// Token: 0x06017C7D RID: 97405 RVA: 0x000981F0 File Offset: 0x000963F0
		[Token(Token = "0x6017C7D")]
		[Address(RVA = "0x1003260", Offset = "0x1001E60", VA = "0x181003260")]
		private bool _BattleFinishOnlyTryLoadDynAvatar(string dynAvatarId)
		{
			return default(bool);
		}

		// Token: 0x06017C7E RID: 97406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C7E")]
		[Address(RVA = "0x1003550", Offset = "0x1002150", VA = "0x181003550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017C7F RID: 97407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C7F")]
		[Address(RVA = "0x1003C00", Offset = "0x1002800", VA = "0x181003C00")]
		public PlayerAvatarView()
		{
		}

		// Token: 0x0401CB66 RID: 117606
		[Token(Token = "0x401CB66")]
		private const float DYN_AVATAR_SCALE = 0.833f;

		// Token: 0x0401CB67 RID: 117607
		[Token(Token = "0x401CB67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _dynAvatarContainer;

		// Token: 0x0401CB68 RID: 117608
		[Token(Token = "0x401CB68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _staticAvatarRoot;

		// Token: 0x0401CB69 RID: 117609
		[Token(Token = "0x401CB69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _staticAvatarSprite;

		// Token: 0x0401CB6A RID: 117610
		[Token(Token = "0x401CB6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401CB6B RID: 117611
		[Token(Token = "0x401CB6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objFrame;

		// Token: 0x0401CB6C RID: 117612
		[Token(Token = "0x401CB6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PlayerAvatarQuery m_avatarQuery;

		// Token: 0x0401CB6D RID: 117613
		[Token(Token = "0x401CB6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayerDynAvatarView m_dynAvatarView;

		// Token: 0x0401CB6E RID: 117614
		[Token(Token = "0x401CB6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401CB6F RID: 117615
		[Token(Token = "0x401CB6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_cacheDynAvatarId;

		// Token: 0x0401CB70 RID: 117616
		[Token(Token = "0x401CB70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0401CB71 RID: 117617
		[Token(Token = "0x401CB71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0401CB72 RID: 117618
		[Token(Token = "0x401CB72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CB73 RID: 117619
		[Token(Token = "0x401CB73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0401CB74 RID: 117620
		[Token(Token = "0x401CB74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix2_Render;

		// Token: 0x0401CB75 RID: 117621
		[Token(Token = "0x401CB75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderByPlayerAvatarQuery;

		// Token: 0x0401CB76 RID: 117622
		[Token(Token = "0x401CB76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix3_Render;

		// Token: 0x0401CB77 RID: 117623
		[Token(Token = "0x401CB77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401CB78 RID: 117624
		[Token(Token = "0x401CB78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryLoadDynAvatar;

		// Token: 0x0401CB79 RID: 117625
		[Token(Token = "0x401CB79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BattleFinishOnlyTryLoadDynAvatar;

		// Token: 0x0401CB7A RID: 117626
		[Token(Token = "0x401CB7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401CB7B RID: 117627
		[Token(Token = "0x401CB7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003AED RID: 15085
		[Token(Token = "0x2003AED")]
		public struct Params
		{
			// Token: 0x0401CB7C RID: 117628
			[Token(Token = "0x401CB7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly PlayerAvatarView.Params DEFAULT;

			// Token: 0x0401CB7D RID: 117629
			[Token(Token = "0x401CB7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool forceUseStaticAvatar;

			// Token: 0x0401CB7E RID: 117630
			[Token(Token = "0x401CB7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool inBattleFinishScene;

			// Token: 0x0401CB7F RID: 117631
			[Token(Token = "0x401CB7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool hideFrame;
		}
	}
}
