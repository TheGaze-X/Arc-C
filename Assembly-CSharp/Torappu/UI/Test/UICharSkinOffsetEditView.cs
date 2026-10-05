using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Test
{
	// Token: 0x02005C1E RID: 23582
	[Token(Token = "0x2005C1E")]
	[ExecuteInEditMode]
	public class UICharSkinOffsetEditView : MonoBehaviour
	{
		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x06022310 RID: 140048 RVA: 0x000BC9B8 File Offset: 0x000BABB8
		[Token(Token = "0x17005035")]
		public bool isBattle
		{
			[Token(Token = "0x6022310")]
			[Address(RVA = "0x1CB5F10", Offset = "0x1CB4B10", VA = "0x181CB5F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022311 RID: 140049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022311")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICharSkinOffsetEditView()
		{
		}

		// Token: 0x0402EE60 RID: 192096
		[Token(Token = "0x402EE60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharSkinOffsetEditView.EditType _editType;

		// Token: 0x0402EE61 RID: 192097
		[Token(Token = "0x402EE61")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x0402EE62 RID: 192098
		[Token(Token = "0x402EE62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _duplicateError;

		// Token: 0x0402EE63 RID: 192099
		[Token(Token = "0x402EE63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Inspect("isBattle")]
		private Vector2 offset;

		// Token: 0x0402EE64 RID: 192100
		[Token(Token = "0x402EE64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Inspect("isBattle")]
		private Vector2 size;

		// Token: 0x0402EE65 RID: 192101
		[Token(Token = "0x402EE65")]
		[FieldOffset(Offset = "0x40")]
		private bool m_startEdit;

		// Token: 0x02005C1F RID: 23583
		[Token(Token = "0x2005C1F")]
		public enum EditType
		{
			// Token: 0x0402EE67 RID: 192103
			[Token(Token = "0x402EE67")]
			Skin,
			// Token: 0x0402EE68 RID: 192104
			[Token(Token = "0x402EE68")]
			Battle
		}
	}
}
