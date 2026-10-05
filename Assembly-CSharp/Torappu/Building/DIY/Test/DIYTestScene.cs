using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x020018F7 RID: 6391
	[Token(Token = "0x20018F7")]
	public class DIYTestScene : MonoBehaviour
	{
		// Token: 0x0600A113 RID: 41235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A113")]
		[Address(RVA = "0x31AAEF0", Offset = "0x31A9AF0", VA = "0x1831AAEF0")]
		private void Awake()
		{
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A114")]
		[Address(RVA = "0x31ACC30", Offset = "0x31AB830", VA = "0x1831ACC30")]
		private void Start()
		{
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A115")]
		[Address(RVA = "0x31AD4D0", Offset = "0x31AC0D0", VA = "0x1831AD4D0")]
		private void Update()
		{
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A116")]
		[Address(RVA = "0x31AC970", Offset = "0x31AB570", VA = "0x1831AC970")]
		private void SetupRoom(int index)
		{
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A117")]
		[Address(RVA = "0x31AD8F0", Offset = "0x31AC4F0", VA = "0x1831AD8F0")]
		private DIYRoom.IFurnitureController _GetFurnitureController(Furniture furniture)
		{
			return null;
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A118")]
		[Address(RVA = "0x31AB410", Offset = "0x31AA010", VA = "0x1831AB410")]
		private void OnGUI()
		{
		}

		// Token: 0x0600A119 RID: 41241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A119")]
		[Address(RVA = "0x31AB300", Offset = "0x31A9F00", VA = "0x1831AB300")]
		private void MoveUp()
		{
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11A")]
		[Address(RVA = "0x31AB0E0", Offset = "0x31A9CE0", VA = "0x1831AB0E0")]
		private void MoveLeft()
		{
		}

		// Token: 0x0600A11B RID: 41243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11B")]
		[Address(RVA = "0x31AAFD0", Offset = "0x31A9BD0", VA = "0x1831AAFD0")]
		private void MoveDown()
		{
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11C")]
		[Address(RVA = "0x31AB1F0", Offset = "0x31A9DF0", VA = "0x1831AB1F0")]
		private void MoveRight()
		{
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11D")]
		[Address(RVA = "0x31AD110", Offset = "0x31ABD10", VA = "0x1831AD110")]
		private void SwitchForward()
		{
		}

		// Token: 0x0600A11E RID: 41246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11E")]
		[Address(RVA = "0x31ACF40", Offset = "0x31ABB40", VA = "0x1831ACF40")]
		private void SwitchBackward()
		{
		}

		// Token: 0x0600A11F RID: 41247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A11F")]
		[Address(RVA = "0x31AD9F0", Offset = "0x31AC5F0", VA = "0x1831AD9F0")]
		public DIYTestScene()
		{
		}

		// Token: 0x04009756 RID: 38742
		[Token(Token = "0x4009756")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockFurnitureManager _furnitureManager;

		// Token: 0x04009757 RID: 38743
		[Token(Token = "0x4009757")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MockFurnitureFromTableManager _furnitureFromTableManager;

		// Token: 0x04009758 RID: 38744
		[Token(Token = "0x4009758")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MockDIYRoomModifierManager _DIYRoomModifierManager;

		// Token: 0x04009759 RID: 38745
		[Token(Token = "0x4009759")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MockDIYRoomInfoManager _DIYRoomInfoManager;

		// Token: 0x0400975A RID: 38746
		[Token(Token = "0x400975A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useTable;

		// Token: 0x0400975B RID: 38747
		[Token(Token = "0x400975B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DIYRoom _room;

		// Token: 0x0400975C RID: 38748
		[Token(Token = "0x400975C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AbstractTable[] _tablesToLoad;

		// Token: 0x0400975D RID: 38749
		[Token(Token = "0x400975D")]
		[FieldOffset(Offset = "0x50")]
		private List<DIYRoom.IFurnitureController> m_controllerList;

		// Token: 0x0400975E RID: 38750
		[Token(Token = "0x400975E")]
		[FieldOffset(Offset = "0x58")]
		private int m_controllerIndex;

		// Token: 0x0400975F RID: 38751
		[Token(Token = "0x400975F")]
		[FieldOffset(Offset = "0x5C")]
		private float m_outlineWidth;

		// Token: 0x04009760 RID: 38752
		[Token(Token = "0x4009760")]
		[FieldOffset(Offset = "0x60")]
		private float m_outlineZ;

		// Token: 0x04009761 RID: 38753
		[Token(Token = "0x4009761")]
		[FieldOffset(Offset = "0x64")]
		private int m_roomCount;

		// Token: 0x04009762 RID: 38754
		[Token(Token = "0x4009762")]
		[FieldOffset(Offset = "0x68")]
		private int m_roomIndex;

		// Token: 0x04009763 RID: 38755
		[Token(Token = "0x4009763")]
		[FieldOffset(Offset = "0x70")]
		private Furniture m_currentFurniture;

		// Token: 0x04009764 RID: 38756
		[Token(Token = "0x4009764")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_scrollVecRoomFurniture;

		// Token: 0x04009765 RID: 38757
		[Token(Token = "0x4009765")]
		[FieldOffset(Offset = "0x80")]
		private Vector2 m_scrollVecStackFurniture;

		// Token: 0x04009766 RID: 38758
		[Token(Token = "0x4009766")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 m_scrollVecStackModifier;

		// Token: 0x04009767 RID: 38759
		[Token(Token = "0x4009767")]
		[FieldOffset(Offset = "0x90")]
		private bool m_uiCollapsed;

		// Token: 0x04009768 RID: 38760
		[Token(Token = "0x4009768")]
		[FieldOffset(Offset = "0x98")]
		private Texture2D m_backTexture0;

		// Token: 0x04009769 RID: 38761
		[Token(Token = "0x4009769")]
		[FieldOffset(Offset = "0xA0")]
		private Texture2D m_backTexture1;

		// Token: 0x0400976A RID: 38762
		[Token(Token = "0x400976A")]
		[FieldOffset(Offset = "0xA8")]
		private IFurnitureManager m_currentFurnitureManager;
	}
}
