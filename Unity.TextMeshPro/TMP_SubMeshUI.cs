using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[RequireComponent(typeof(CanvasRenderer))]
	[ExecuteAlways]
	public class TMP_SubMeshUI : MaskableGraphic
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FD")]
		public TMP_FontAsset fontAsset
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x4D6CBB0", Offset = "0x4D6B7B0", VA = "0x184D6CBB0")]
			set
			{
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FE")]
		public TMP_SpriteAsset spriteAsset
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x4D6CFE0", Offset = "0x4D6BBE0", VA = "0x184D6CFE0")]
			set
			{
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FF")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x58CFFE0", Offset = "0x58CEBE0", VA = "0x1858CFFE0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000100")]
		public override Material material
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x58D0100", Offset = "0x58CED00", VA = "0x1858D0100", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x58D03E0", Offset = "0x58CEFE0", VA = "0x1858D03E0", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000101")]
		public Material sharedMaterial
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x58D0530", Offset = "0x58CF130", VA = "0x1858D0530")]
			set
			{
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000102")]
		public Material fallbackMaterial
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x58D02A0", Offset = "0x58CEEA0", VA = "0x1858D02A0")]
			set
			{
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000103")]
		public Material fallbackSourceMaterial
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
			set
			{
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000104")]
		public override Material materialForRendering
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x58D00A0", Offset = "0x58CECA0", VA = "0x1858D00A0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000105")]
		public bool isDefaultMaterial
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x538F7C0", Offset = "0x538E3C0", VA = "0x18538F7C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x538FBD0", Offset = "0x538E7D0", VA = "0x18538FBD0")]
			set
			{
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000106")]
		public float padding
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x58D01E0", Offset = "0x58CEDE0", VA = "0x1858D01E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x58D0520", Offset = "0x58CF120", VA = "0x1858D0520")]
			set
			{
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000107")]
		public Mesh mesh
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x58D0110", Offset = "0x58CED10", VA = "0x1858D0110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1692BB0", Offset = "0x16917B0", VA = "0x181692BB0")]
			set
			{
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000108")]
		public TMP_Text textComponent
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x58D01F0", Offset = "0x58CEDF0", VA = "0x1858D01F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x58CEC20", Offset = "0x58CD820", VA = "0x1858CEC20")]
		public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
		{
			return null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x58CF920", Offset = "0x58CE520", VA = "0x1858CF920", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x58CF860", Offset = "0x58CE460", VA = "0x1858CF860", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x58CF660", Offset = "0x58CE260", VA = "0x1858CF660", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x58CF9B0", Offset = "0x58CE5B0", VA = "0x1858CF9B0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x58CF300", Offset = "0x58CDF00", VA = "0x1858CF300", Slot = "60")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x58CF4E0", Offset = "0x58CE0E0", VA = "0x1858CF4E0")]
		public float GetPaddingForMaterial()
		{
			return 0f;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x58CF450", Offset = "0x58CE050", VA = "0x1858CF450")]
		public float GetPaddingForMaterial(Material mat)
		{
			return 0f;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x58CFF50", Offset = "0x58CEB50", VA = "0x1858CFF50")]
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "28")]
		public override void SetAllDirty()
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x58CFC00", Offset = "0x58CE800", VA = "0x1858CFC00", Slot = "30")]
		public override void SetVerticesDirty()
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public override void SetLayoutDirty()
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x58CFA90", Offset = "0x58CE690", VA = "0x1858CFA90", Slot = "31")]
		public override void SetMaterialDirty()
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x58CFAF0", Offset = "0x58CE6F0", VA = "0x1858CFAF0")]
		public void SetPivotDirty()
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x58CF570", Offset = "0x58CE170", VA = "0x1858CF570")]
		private Transform GetRootCanvasTransform()
		{
			return null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "61")]
		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x58CFA40", Offset = "0x58CE640", VA = "0x1858CFA40", Slot = "39")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x587D280", Offset = "0x587BE80", VA = "0x18587D280")]
		public void RefreshMaterial()
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x58CFCF0", Offset = "0x58CE8F0", VA = "0x1858CFCF0", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x5871830", Offset = "0x5870430", VA = "0x185871830", Slot = "65")]
		public override void RecalculateClipping()
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
		private Material GetMaterial()
		{
			return null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x58CF120", Offset = "0x58CDD20", VA = "0x1858CF120")]
		private Material GetMaterial(Material mat)
		{
			return null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x58CF060", Offset = "0x58CDC60", VA = "0x1858CF060")]
		private Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x58CF630", Offset = "0x58CE230", VA = "0x1858CF630")]
		private Material GetSharedMaterial()
		{
			return null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x58CFB80", Offset = "0x58CE780", VA = "0x1858CFB80")]
		private void SetSharedMaterial(Material mat)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x5543E70", Offset = "0x5542A70", VA = "0x185543E70")]
		public TMP_SubMeshUI()
		{
		}

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Material m_material;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Material m_sharedMaterial;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x108")]
		private Material m_fallbackMaterial;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x110")]
		private Material m_fallbackSourceMaterial;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool m_isDefaultMaterial;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float m_padding;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x120")]
		private Mesh m_mesh;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private TextMeshProUGUI m_TextComponent;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		private bool m_isRegisteredForEvents;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x131")]
		private bool m_materialDirty;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private int m_materialReferenceIndex;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x138")]
		private Transform m_RootCanvasTransform;
	}
}
