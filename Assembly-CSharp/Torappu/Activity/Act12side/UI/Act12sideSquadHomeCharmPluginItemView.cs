using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007ABC RID: 31420
	[Token(Token = "0x2007ABC")]
	public class Act12sideSquadHomeCharmPluginItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006724 RID: 26404
		// (get) Token: 0x0602C024 RID: 180260 RVA: 0x000DDE20 File Offset: 0x000DC020
		[Token(Token = "0x17006724")]
		public float Angle
		{
			[Token(Token = "0x602C024")]
			[Address(RVA = "0x27FFA80", Offset = "0x27FE680", VA = "0x1827FFA80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17006725 RID: 26405
		// (get) Token: 0x0602C025 RID: 180261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006725")]
		public string charmId
		{
			[Token(Token = "0x602C025")]
			[Address(RVA = "0x27FFAE0", Offset = "0x27FE6E0", VA = "0x1827FFAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C026 RID: 180262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C026")]
		[Address(RVA = "0x27FF520", Offset = "0x27FE120", VA = "0x1827FF520")]
		public void Render(string charmId, Action onClickItem, float angle)
		{
		}

		// Token: 0x0602C027 RID: 180263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C027")]
		[Address(RVA = "0x27FF4B0", Offset = "0x27FE0B0", VA = "0x1827FF4B0")]
		public void OnCharmItemClick()
		{
		}

		// Token: 0x0602C028 RID: 180264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C028")]
		[Address(RVA = "0x27FF820", Offset = "0x27FE420", VA = "0x1827FF820")]
		private Sprite _LoadIconSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0602C029 RID: 180265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C029")]
		[Address(RVA = "0x27FFA20", Offset = "0x27FE620", VA = "0x1827FFA20")]
		public Act12sideSquadHomeCharmPluginItemView()
		{
		}

		// Token: 0x0403FC49 RID: 261193
		[Token(Token = "0x403FC49")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCharmItem;

		// Token: 0x0403FC4A RID: 261194
		[Token(Token = "0x403FC4A")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onClickItem;

		// Token: 0x0403FC4B RID: 261195
		[Token(Token = "0x403FC4B")]
		[FieldOffset(Offset = "0x28")]
		private float m_angle;

		// Token: 0x0403FC4C RID: 261196
		[Token(Token = "0x403FC4C")]
		[FieldOffset(Offset = "0x30")]
		private string m_charmId;

		// Token: 0x0403FC4D RID: 261197
		[Token(Token = "0x403FC4D")]
		private const float ITEM_SCALE = 0.6f;

		// Token: 0x0403FC4E RID: 261198
		[Token(Token = "0x403FC4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_Angle;

		// Token: 0x0403FC4F RID: 261199
		[Token(Token = "0x403FC4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charmId;

		// Token: 0x0403FC50 RID: 261200
		[Token(Token = "0x403FC50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FC51 RID: 261201
		[Token(Token = "0x403FC51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCharmItemClick;

		// Token: 0x0403FC52 RID: 261202
		[Token(Token = "0x403FC52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadIconSprite;

		// Token: 0x0403FC53 RID: 261203
		[Token(Token = "0x403FC53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
