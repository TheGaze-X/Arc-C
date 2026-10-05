using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002257 RID: 8791
	[Token(Token = "0x2002257")]
	public class Aircraft : SingletonMonoBehaviour<Aircraft>, ISingletonNotAutoCreate
	{
		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x0600DCC3 RID: 56515 RVA: 0x000509A0 File Offset: 0x0004EBA0
		[Token(Token = "0x17001BC8")]
		public int width
		{
			[Token(Token = "0x600DCC3")]
			[Address(RVA = "0x3611090", Offset = "0x360FC90", VA = "0x183611090")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x000509B8 File Offset: 0x0004EBB8
		[Token(Token = "0x17001BC9")]
		public int height
		{
			[Token(Token = "0x600DCC4")]
			[Address(RVA = "0x3611020", Offset = "0x360FC20", VA = "0x183611020")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x0600DCC5 RID: 56517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BCA")]
		public Map.Tiles2D Tile
		{
			[Token(Token = "0x600DCC5")]
			[Address(RVA = "0x3610F00", Offset = "0x360FB00", VA = "0x183610F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x000509D0 File Offset: 0x0004EBD0
		[Token(Token = "0x17001BCB")]
		public float charColliderR
		{
			[Token(Token = "0x600DCC6")]
			[Address(RVA = "0x3610F60", Offset = "0x360FB60", VA = "0x183610F60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x0600DCC7 RID: 56519 RVA: 0x000509E8 File Offset: 0x0004EBE8
		[Token(Token = "0x17001BCC")]
		public float defaultZ
		{
			[Token(Token = "0x600DCC7")]
			[Address(RVA = "0x3610FC0", Offset = "0x360FBC0", VA = "0x183610FC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600DCC8 RID: 56520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCC8")]
		[Address(RVA = "0x360EA60", Offset = "0x360D660", VA = "0x18360EA60")]
		public void AddCharacter(Character character)
		{
		}

		// Token: 0x0600DCC9 RID: 56521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCC9")]
		[Address(RVA = "0x360FEA0", Offset = "0x360EAA0", VA = "0x18360FEA0")]
		public void RemoveCharacter(Character character)
		{
		}

		// Token: 0x0600DCCA RID: 56522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCCA")]
		[Address(RVA = "0x360F750", Offset = "0x360E350", VA = "0x18360F750")]
		public void InitAircraft()
		{
		}

		// Token: 0x0600DCCB RID: 56523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCCB")]
		[Address(RVA = "0x360F590", Offset = "0x360E190", VA = "0x18360F590")]
		public void ImportTiles()
		{
		}

		// Token: 0x0600DCCC RID: 56524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCCC")]
		[Address(RVA = "0x3610050", Offset = "0x360EC50", VA = "0x183610050")]
		private void Update()
		{
		}

		// Token: 0x0600DCCD RID: 56525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCCD")]
		[Address(RVA = "0x36107E0", Offset = "0x360F3E0", VA = "0x1836107E0")]
		private void _OnBegin(Vector2 scrPos)
		{
		}

		// Token: 0x0600DCCE RID: 56526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCCE")]
		[Address(RVA = "0x3610A80", Offset = "0x360F680", VA = "0x183610A80")]
		private void _OnMove(Vector2 scrPos)
		{
		}

		// Token: 0x0600DCCF RID: 56527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCCF")]
		[Address(RVA = "0x3610890", Offset = "0x360F490", VA = "0x183610890")]
		private void _OnKeyboard()
		{
		}

		// Token: 0x0600DCD0 RID: 56528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCD0")]
		[Address(RVA = "0x36102F0", Offset = "0x360EEF0", VA = "0x1836102F0")]
		private void _MoveAircraft(Vector3 offset)
		{
		}

		// Token: 0x0600DCD1 RID: 56529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCD1")]
		[Address(RVA = "0x360F280", Offset = "0x360DE80", VA = "0x18360F280")]
		public Tile GetTileFromScreenPos(Vector2 screenPos, out Vector2 mapPos)
		{
			return null;
		}

		// Token: 0x0600DCD2 RID: 56530 RVA: 0x00050A00 File Offset: 0x0004EC00
		[Token(Token = "0x600DCD2")]
		[Address(RVA = "0x360F0A0", Offset = "0x360DCA0", VA = "0x18360F0A0")]
		private bool GetMapPosByScreenPos(Vector2 screenPos, out Vector2 mapPos)
		{
			return default(bool);
		}

		// Token: 0x0600DCD3 RID: 56531 RVA: 0x00050A18 File Offset: 0x0004EC18
		[Token(Token = "0x600DCD3")]
		[Address(RVA = "0x3610220", Offset = "0x360EE20", VA = "0x183610220")]
		private Vector2 WorldToMapPosition(Vector3 worldPos)
		{
			return default(Vector2);
		}

		// Token: 0x0600DCD4 RID: 56532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCD4")]
		[Address(RVA = "0x360EC60", Offset = "0x360D860", VA = "0x18360EC60")]
		private void CheckBorder()
		{
		}

		// Token: 0x0600DCD5 RID: 56533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCD5")]
		[Address(RVA = "0x3610D20", Offset = "0x360F920", VA = "0x183610D20")]
		public Aircraft()
		{
		}

		// Token: 0x0400EF12 RID: 61202
		[Token(Token = "0x400EF12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Movement")]
		private float _speed;

		// Token: 0x0400EF13 RID: 61203
		[Token(Token = "0x400EF13")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Group("Movement")]
		private int _moveHeight;

		// Token: 0x0400EF14 RID: 61204
		[Token(Token = "0x400EF14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Movement")]
		private int _moveWidth;

		// Token: 0x0400EF15 RID: 61205
		[Token(Token = "0x400EF15")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Group("Movement")]
		private float _defaultZ;

		// Token: 0x0400EF16 RID: 61206
		[Token(Token = "0x400EF16")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Movement")]
		private float _maxMovementPerFrame;

		// Token: 0x0400EF17 RID: 61207
		[Token(Token = "0x400EF17")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _skillGridRangeDrawerPrefab;

		// Token: 0x0400EF18 RID: 61208
		[Token(Token = "0x400EF18")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _charColloderR;

		// Token: 0x0400EF19 RID: 61209
		[Token(Token = "0x400EF19")]
		[FieldOffset(Offset = "0x40")]
		private Map.Tiles2D m_tiles;

		// Token: 0x0400EF1A RID: 61210
		[Token(Token = "0x400EF1A")]
		[FieldOffset(Offset = "0x48")]
		private Aircraft.Border m_border;

		// Token: 0x0400EF1B RID: 61211
		[Token(Token = "0x400EF1B")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 m_beginPos;

		// Token: 0x0400EF1C RID: 61212
		[Token(Token = "0x400EF1C")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 m_endPos;

		// Token: 0x0400EF1D RID: 61213
		[Token(Token = "0x400EF1D")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_skillGridRangeDrawer;

		// Token: 0x0400EF1E RID: 61214
		[Token(Token = "0x400EF1E")]
		[FieldOffset(Offset = "0x70")]
		private ResidentCharacterRangeDrawer m_gridRangeDrawer;

		// Token: 0x0400EF1F RID: 61215
		[Token(Token = "0x400EF1F")]
		[FieldOffset(Offset = "0x78")]
		private List<Transform> m_characterContainer;

		// Token: 0x0400EF20 RID: 61216
		[Token(Token = "0x400EF20")]
		[FieldOffset(Offset = "0x80")]
		private int m_touchFingerId;

		// Token: 0x0400EF21 RID: 61217
		[Token(Token = "0x400EF21")]
		[FieldOffset(Offset = "0x84")]
		private int m_touchCount;

		// Token: 0x0400EF22 RID: 61218
		[Token(Token = "0x400EF22")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInit;

		// Token: 0x0400EF23 RID: 61219
		[Token(Token = "0x400EF23")]
		[FieldOffset(Offset = "0x90")]
		private IList<Character> m_characters;

		// Token: 0x0400EF24 RID: 61220
		[Token(Token = "0x400EF24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_width;

		// Token: 0x0400EF25 RID: 61221
		[Token(Token = "0x400EF25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_height;

		// Token: 0x0400EF26 RID: 61222
		[Token(Token = "0x400EF26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_Tile;

		// Token: 0x0400EF27 RID: 61223
		[Token(Token = "0x400EF27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charColliderR;

		// Token: 0x0400EF28 RID: 61224
		[Token(Token = "0x400EF28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_defaultZ;

		// Token: 0x0400EF29 RID: 61225
		[Token(Token = "0x400EF29")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddCharacter;

		// Token: 0x0400EF2A RID: 61226
		[Token(Token = "0x400EF2A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RemoveCharacter;

		// Token: 0x0400EF2B RID: 61227
		[Token(Token = "0x400EF2B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitAircraft;

		// Token: 0x0400EF2C RID: 61228
		[Token(Token = "0x400EF2C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ImportTiles;

		// Token: 0x0400EF2D RID: 61229
		[Token(Token = "0x400EF2D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400EF2E RID: 61230
		[Token(Token = "0x400EF2E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBegin;

		// Token: 0x0400EF2F RID: 61231
		[Token(Token = "0x400EF2F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnMove;

		// Token: 0x0400EF30 RID: 61232
		[Token(Token = "0x400EF30")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnKeyboard;

		// Token: 0x0400EF31 RID: 61233
		[Token(Token = "0x400EF31")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__MoveAircraft;

		// Token: 0x0400EF32 RID: 61234
		[Token(Token = "0x400EF32")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTileFromScreenPos;

		// Token: 0x0400EF33 RID: 61235
		[Token(Token = "0x400EF33")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetMapPosByScreenPos;

		// Token: 0x0400EF34 RID: 61236
		[Token(Token = "0x400EF34")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_WorldToMapPosition;

		// Token: 0x0400EF35 RID: 61237
		[Token(Token = "0x400EF35")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckBorder;

		// Token: 0x0400EF36 RID: 61238
		[Token(Token = "0x400EF36")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002258 RID: 8792
		[Token(Token = "0x2002258")]
		private class Border
		{
			// Token: 0x0600DCD6 RID: 56534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DCD6")]
			[Address(RVA = "0x361D330", Offset = "0x361BF30", VA = "0x18361D330")]
			public Border()
			{
			}

			// Token: 0x17001BCD RID: 7117
			// (get) Token: 0x0600DCD7 RID: 56535 RVA: 0x00050A30 File Offset: 0x0004EC30
			// (set) Token: 0x0600DCD8 RID: 56536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BCD")]
			public float Up
			{
				[Token(Token = "0x600DCD7")]
				[Address(RVA = "0x4E65D0", Offset = "0x4E51D0", VA = "0x1804E65D0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600DCD8")]
				[Address(RVA = "0x4E65E0", Offset = "0x4E51E0", VA = "0x1804E65E0")]
				set
				{
				}
			}

			// Token: 0x17001BCE RID: 7118
			// (get) Token: 0x0600DCD9 RID: 56537 RVA: 0x00050A48 File Offset: 0x0004EC48
			// (set) Token: 0x0600DCDA RID: 56538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BCE")]
			public float Down
			{
				[Token(Token = "0x600DCD9")]
				[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600DCDA")]
				[Address(RVA = "0x4F1EC0", Offset = "0x4F0AC0", VA = "0x1804F1EC0")]
				set
				{
				}
			}

			// Token: 0x17001BCF RID: 7119
			// (get) Token: 0x0600DCDB RID: 56539 RVA: 0x00050A60 File Offset: 0x0004EC60
			// (set) Token: 0x0600DCDC RID: 56540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BCF")]
			public float Left
			{
				[Token(Token = "0x600DCDB")]
				[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600DCDC")]
				[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
				set
				{
				}
			}

			// Token: 0x17001BD0 RID: 7120
			// (get) Token: 0x0600DCDD RID: 56541 RVA: 0x00050A78 File Offset: 0x0004EC78
			// (set) Token: 0x0600DCDE RID: 56542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BD0")]
			public float Right
			{
				[Token(Token = "0x600DCDD")]
				[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600DCDE")]
				[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
				set
				{
				}
			}

			// Token: 0x0400EF37 RID: 61239
			[Token(Token = "0x400EF37")]
			[FieldOffset(Offset = "0x10")]
			private float up;

			// Token: 0x0400EF38 RID: 61240
			[Token(Token = "0x400EF38")]
			[FieldOffset(Offset = "0x14")]
			private float down;

			// Token: 0x0400EF39 RID: 61241
			[Token(Token = "0x400EF39")]
			[FieldOffset(Offset = "0x18")]
			private float left;

			// Token: 0x0400EF3A RID: 61242
			[Token(Token = "0x400EF3A")]
			[FieldOffset(Offset = "0x1C")]
			private float right;
		}
	}
}
