using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[ExecuteAlways]
	[RequireComponent(typeof(MeshRenderer))]
	public class TMP_SubMesh : MonoBehaviour
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F1")]
		public TMP_FontAsset fontAsset
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F2")]
		public TMP_SpriteAsset spriteAsset
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F3")]
		public Material material
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x58D1650", Offset = "0x58D0250", VA = "0x1858D1650")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x58D1AE0", Offset = "0x58D06E0", VA = "0x1858D1AE0")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F4")]
		public Material sharedMaterial
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x58D12C0", Offset = "0x58CFEC0", VA = "0x1858D12C0")]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F5")]
		public Material fallbackMaterial
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x58D1980", Offset = "0x58D0580", VA = "0x1858D1980")]
			set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F6")]
		public Material fallbackSourceMaterial
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00003828 File Offset: 0x00001A28
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		public bool isDefaultMaterial
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F8")]
		public float padding
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x17DB8E0", Offset = "0x17DA4E0", VA = "0x1817DB8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x17DB8F0", Offset = "0x17DA4F0", VA = "0x1817DB8F0")]
			set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F9")]
		public Renderer renderer
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x58D1840", Offset = "0x58D0440", VA = "0x1858D1840")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FA")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x58D1660", Offset = "0x58D0260", VA = "0x1858D1660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FB")]
		public Mesh mesh
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x58D1780", Offset = "0x58D0380", VA = "0x1858D1780")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			set
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FC")]
		public TMP_Text textComponent
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x58D18E0", Offset = "0x58D04E0", VA = "0x1858D18E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x58D0540", Offset = "0x58CF140", VA = "0x1858D0540")]
		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x58D1000", Offset = "0x58CFC00", VA = "0x1858D1000")]
		private void OnEnable()
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x58D0F40", Offset = "0x58CFB40", VA = "0x1858D0F40")]
		private void OnDisable()
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x58D0DD0", Offset = "0x58CF9D0", VA = "0x1858D0DD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x58D0A40", Offset = "0x58CF640", VA = "0x1858D0A40")]
		public void DestroySelf()
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x58D0AA0", Offset = "0x58CF6A0", VA = "0x1858D0AA0")]
		private Material GetMaterial(Material mat)
		{
			return null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x58D0980", Offset = "0x58CF580", VA = "0x1858D0980")]
		private Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x58D0D20", Offset = "0x58CF920", VA = "0x1858D0D20")]
		private Material GetSharedMaterial()
		{
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x58D12C0", Offset = "0x58CFEC0", VA = "0x1858D12C0")]
		private void SetSharedMaterial(Material mat)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x58D0C90", Offset = "0x58CF890", VA = "0x1858D0C90")]
		public float GetPaddingForMaterial()
		{
			return 0f;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x58D15D0", Offset = "0x58D01D0", VA = "0x1858D15D0")]
		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x58D1300", Offset = "0x58CFF00", VA = "0x1858D1300")]
		public void SetVerticesDirty()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x58D12B0", Offset = "0x58CFEB0", VA = "0x1858D12B0")]
		public void SetMaterialDirty()
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x58D13C0", Offset = "0x58CFFC0", VA = "0x1858D13C0")]
		protected void UpdateMaterial()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public TMP_SubMesh()
		{
		}

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Material m_material;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material m_sharedMaterial;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x38")]
		private Material m_fallbackMaterial;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x40")]
		private Material m_fallbackSourceMaterial;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_isDefaultMaterial;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_padding;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Renderer m_renderer;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x58")]
		private MeshFilter m_meshFilter;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x60")]
		private Mesh m_mesh;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshPro m_TextComponent;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private bool m_isRegisteredForEvents;
	}
}
