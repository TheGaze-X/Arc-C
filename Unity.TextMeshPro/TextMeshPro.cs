using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[ExecuteAlways]
	[AddComponentMenu("Mesh/TextMeshPro - Text")]
	[RequireComponent(typeof(MeshRenderer))]
	[DisallowMultipleComponent]
	public class TextMeshPro : TMP_Text, ILayoutElement
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public int sortingLayerID
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x587F750", Offset = "0x587E350", VA = "0x18587F750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x587FA70", Offset = "0x587E670", VA = "0x18587FA70")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public int sortingOrder
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x587F7E0", Offset = "0x587E3E0", VA = "0x18587F7E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x587FC30", Offset = "0x587E830", VA = "0x18587FC30")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public override bool autoSizeTextContainer
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x5877290", Offset = "0x5875E90", VA = "0x185877290", Slot = "77")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x587F9D0", Offset = "0x587E5D0", VA = "0x18587F9D0", Slot = "78")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000014")]
		[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
		public TextContainer textContainer
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000015")]
		public new Transform transform
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x587F870", Offset = "0x587E470", VA = "0x18587F870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000016")]
		public Renderer renderer
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x587F6A0", Offset = "0x587E2A0", VA = "0x18587F6A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000017")]
		public override Mesh mesh
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x587F5D0", Offset = "0x587E1D0", VA = "0x18587F5D0", Slot = "79")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000018")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x587F4B0", Offset = "0x587E0B0", VA = "0x18587F4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public MaskingTypes maskType
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x587F4A0", Offset = "0x587E0A0", VA = "0x18587F4A0")]
			get
			{
				return MaskingTypes.MaskOff;
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x587FA60", Offset = "0x587E660", VA = "0x18587FA60")]
			set
			{
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x587CF20", Offset = "0x587BB20", VA = "0x18587CF20")]
		public void SetMask(MaskingTypes type, Vector4 maskCoords)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x587D170", Offset = "0x587BD70", VA = "0x18587D170")]
		public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x587DE60", Offset = "0x587CA60", VA = "0x18587DE60", Slot = "30")]
		public override void SetVerticesDirty()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x587CCA0", Offset = "0x587B8A0", VA = "0x18587CCA0", Slot = "29")]
		public override void SetLayoutDirty()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x587D280", Offset = "0x587BE80", VA = "0x18587D280", Slot = "31")]
		public override void SetMaterialDirty()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5871980", Offset = "0x5870580", VA = "0x185871980", Slot = "28")]
		public override void SetAllDirty()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5879E60", Offset = "0x5878A60", VA = "0x185879E60", Slot = "39")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x587E360", Offset = "0x587CF60", VA = "0x18587E360", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x587E4A0", Offset = "0x587D0A0", VA = "0x18587E4A0", Slot = "113")]
		public override void UpdateMeshPadding()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x58781D0", Offset = "0x5876DD0", VA = "0x1858781D0", Slot = "108")]
		public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5878BD0", Offset = "0x58777D0", VA = "0x185878BD0", Slot = "120")]
		public override TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x58779D0", Offset = "0x58765D0", VA = "0x1858779D0", Slot = "132")]
		public override void ClearMesh(bool updateMesh)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public override event Action<TMP_TextInfo> OnPreRenderText
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x587F3F0", Offset = "0x587DFF0", VA = "0x18587F3F0", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x587F920", Offset = "0x587E520", VA = "0x18587F920", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x587E1F0", Offset = "0x587CDF0", VA = "0x18587E1F0", Slot = "109")]
		public override void UpdateGeometry(Mesh mesh, int index)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x587EA70", Offset = "0x587D670", VA = "0x18587EA70", Slot = "110")]
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x587EC70", Offset = "0x587D870", VA = "0x18587EC70", Slot = "111")]
		public override void UpdateVertexData()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x5875BD0", Offset = "0x58747D0", VA = "0x185875BD0")]
		public void UpdateFontAsset()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "135")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "136")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5877540", Offset = "0x5876140", VA = "0x185877540", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x58796F0", Offset = "0x58782F0", VA = "0x1858796F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5879640", Offset = "0x5878240", VA = "0x185879640", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x5879520", Offset = "0x5878120", VA = "0x185879520", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x5878D50", Offset = "0x5877950", VA = "0x185878D50", Slot = "91")]
		protected override void LoadFontAsset()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x587DF10", Offset = "0x587CB10", VA = "0x18587DF10")]
		private void UpdateEnvMapMatrix()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x587CFC0", Offset = "0x587BBC0", VA = "0x18587CFC0")]
		private void SetMask(MaskingTypes maskType)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x587CE90", Offset = "0x587BA90", VA = "0x18587CE90")]
		private void SetMaskCoordinates(Vector4 coords)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x587CD80", Offset = "0x587B980", VA = "0x18587CD80")]
		private void SetMaskCoordinates(Vector4 coords, float softX, float softY)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x5878090", Offset = "0x5876C90", VA = "0x185878090")]
		private void EnableMasking()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5877E30", Offset = "0x5876A30", VA = "0x185877E30")]
		private void DisableMasking()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x587E210", Offset = "0x587CE10", VA = "0x18587E210")]
		private void UpdateMask()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x5878580", Offset = "0x5877180", VA = "0x185878580", Slot = "93")]
		protected override Material GetMaterial(Material mat)
		{
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5878710", Offset = "0x5877310", VA = "0x185878710", Slot = "97")]
		protected override Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x5875050", Offset = "0x5873C50", VA = "0x185875050", Slot = "92")]
		protected override void SetSharedMaterial(Material mat)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5878920", Offset = "0x5877520", VA = "0x185878920", Slot = "95")]
		protected override Material[] GetSharedMaterials()
		{
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x587DA30", Offset = "0x587C630", VA = "0x18587DA30", Slot = "96")]
		protected override void SetSharedMaterials(Material[] materials)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x587D690", Offset = "0x587C290", VA = "0x18587D690", Slot = "101")]
		protected override void SetOutlineThickness(float thickness)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x587CB10", Offset = "0x587B710", VA = "0x18587CB10", Slot = "99")]
		protected override void SetFaceColor(Color32 color)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x587D500", Offset = "0x587C100", VA = "0x18587D500", Slot = "100")]
		protected override void SetOutlineColor(Color32 color)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5877C40", Offset = "0x5876840", VA = "0x185877C40")]
		private void CreateMaterialInstance()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x587D8E0", Offset = "0x587C4E0", VA = "0x18587D8E0", Slot = "102")]
		protected override void SetShaderDepth()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x587C7B0", Offset = "0x587B3B0", VA = "0x18587C7B0", Slot = "103")]
		protected override void SetCulling()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x587D820", Offset = "0x587C420", VA = "0x18587D820")]
		private void SetPerspectiveCorrection()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x587A1F0", Offset = "0x5878DF0", VA = "0x18587A1F0", Slot = "116")]
		internal override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars)
		{
			return 0;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x5877AC0", Offset = "0x58766C0", VA = "0x185877AC0", Slot = "121")]
		public override void ComputeMarginSize()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x58795F0", Offset = "0x58781F0", VA = "0x1858795F0", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5879E00", Offset = "0x5878A00", VA = "0x185879E00", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5879C00", Offset = "0x5878800", VA = "0x185879C00", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5878C90", Offset = "0x5877890", VA = "0x185878C90", Slot = "134")]
		internal override void InternalUpdate()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5879830", Offset = "0x5878430", VA = "0x185879830")]
		private void OnPreRenderObject()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x5853400", Offset = "0x5852000", VA = "0x185853400", Slot = "144")]
		protected virtual void GenerateTextMesh()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5878B10", Offset = "0x5877710", VA = "0x185878B10", Slot = "107")]
		protected override Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x587D2C0", Offset = "0x587BEC0", VA = "0x18587D2C0")]
		private void SetMeshFilters(bool state)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x5879F40", Offset = "0x5878B40", VA = "0x185879F40", Slot = "129")]
		protected override void SetActiveSubMeshes(bool state)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x587A080", Offset = "0x5878C80", VA = "0x18587A080")]
		protected void SetActiveSubTextObjectRenderers(bool state)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x5877D20", Offset = "0x5876920", VA = "0x185877D20", Slot = "130")]
		protected override void DestroySubMeshObjects()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x587E7D0", Offset = "0x587D3D0", VA = "0x18587E7D0")]
		internal void UpdateSubMeshSortingLayerID(int id)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x587E920", Offset = "0x587D520", VA = "0x18587E920")]
		internal void UpdateSubMeshSortingOrder(int order)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x58781F0", Offset = "0x5876DF0", VA = "0x1858781F0", Slot = "118")]
		protected override Bounds GetCompoundBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x587E5C0", Offset = "0x587D1C0", VA = "0x18587E5C0")]
		private void UpdateSDFScale(float scaleDelta)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x587F320", Offset = "0x587DF20", VA = "0x18587F320")]
		public TextMeshPro()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x6D8")]
		[SerializeField]
		internal int _SortingLayer;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x6DC")]
		[SerializeField]
		internal int _SortingLayerID;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x6E0")]
		[SerializeField]
		internal int _SortingOrder;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x6F0")]
		private bool m_currentAutoSizeMode;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x6F1")]
		[SerializeField]
		private bool m_hasFontAssetChanged;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x6F4")]
		private float m_previousLossyScaleY;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x6F8")]
		[SerializeField]
		private Renderer m_renderer;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x700")]
		private MeshFilter m_meshFilter;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x708")]
		private bool m_isFirstAllocation;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x70C")]
		private int m_max_characters;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x710")]
		private int m_max_numberOfLines;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x718")]
		private TMP_SubMesh[] m_subTextObjects;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x720")]
		[SerializeField]
		private MaskingTypes m_maskType;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x724")]
		private Matrix4x4 m_EnvMapMatrix;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x768")]
		private Vector3[] m_RectTransformCorners;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x770")]
		[NonSerialized]
		private bool m_isRegisteredForEvents;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_GenerateTextMarker;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_SetArraySizesMarker;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_GenerateTextPhaseIMarker;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_ParseMarkupTextMarker;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_CharacterLookupMarker;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_HandleGPOSFeaturesMarker;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_CalculateVerticesPositionMarker;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker k_ComputeTextMetricsMarker;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker k_HandleVisibleCharacterMarker;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker k_HandleWhiteSpacesMarker;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x58")]
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x60")]
		private static ProfilerMarker k_SaveGlyphVertexDataMarker;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x68")]
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x70")]
		private static ProfilerMarker k_HandleCarriageReturnMarker;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x78")]
		private static ProfilerMarker k_HandleLineTerminationMarker;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x80")]
		private static ProfilerMarker k_SavePageInfoMarker;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x88")]
		private static ProfilerMarker k_SaveProcessingStatesMarker;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x90")]
		private static ProfilerMarker k_GenerateTextPhaseIIMarker;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x98")]
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker;
	}
}
