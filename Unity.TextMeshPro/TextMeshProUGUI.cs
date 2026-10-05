using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[RequireComponent(typeof(CanvasRenderer))]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.0")]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
	[DisallowMultipleComponent]
	public class TextMeshProUGUI : TMP_Text, ILayoutElement
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001A")]
		public override Material materialForRendering
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x5877360", Offset = "0x5875F60", VA = "0x185877360", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002358 File Offset: 0x00000558
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public override bool autoSizeTextContainer
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x5877290", Offset = "0x5875E90", VA = "0x185877290", Slot = "77")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x5877480", Offset = "0x5876080", VA = "0x185877480", Slot = "78")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001C")]
		public override Mesh mesh
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x58773C0", Offset = "0x5875FC0", VA = "0x1858773C0", Slot = "79")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001D")]
		public new CanvasRenderer canvasRenderer
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x58772A0", Offset = "0x5875EA0", VA = "0x1858772A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "135")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "136")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x58755C0", Offset = "0x58741C0", VA = "0x1858755C0", Slot = "30")]
		public override void SetVerticesDirty()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x5874790", Offset = "0x5873390", VA = "0x185874790", Slot = "29")]
		public override void SetLayoutDirty()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x5874880", Offset = "0x5873480", VA = "0x185874880", Slot = "31")]
		public override void SetMaterialDirty()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x5871980", Offset = "0x5870580", VA = "0x185871980", Slot = "28")]
		public override void SetAllDirty()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x586E920", Offset = "0x586D520", VA = "0x18586E920")]
		private IEnumerator DelayedGraphicRebuild()
		{
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x586E9A0", Offset = "0x586D5A0", VA = "0x18586E9A0")]
		private IEnumerator DelayedMaterialRebuild()
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x5871750", Offset = "0x5870350", VA = "0x185871750", Slot = "39")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x58766B0", Offset = "0x58752B0", VA = "0x1858766B0")]
		private void UpdateSubObjectPivot()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x586F9F0", Offset = "0x586E5F0", VA = "0x18586F9F0", Slot = "60")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5876170", Offset = "0x5874D70", VA = "0x185876170", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002370 File Offset: 0x00000570
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public Vector4 maskOffset
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x5877350", Offset = "0x5875F50", VA = "0x185877350")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x5877510", Offset = "0x5876110", VA = "0x185877510")]
			set
			{
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x5871830", Offset = "0x5870430", VA = "0x185871830", Slot = "65")]
		public override void RecalculateClipping()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x586E680", Offset = "0x586D280", VA = "0x18586E680", Slot = "61")]
		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x58756A0", Offset = "0x58742A0", VA = "0x1858756A0", Slot = "104")]
		internal override void UpdateCulling()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x58762E0", Offset = "0x5874EE0", VA = "0x1858762E0", Slot = "113")]
		public override void UpdateMeshPadding()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5870000", Offset = "0x586EC00", VA = "0x185870000", Slot = "114")]
		protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x586FF20", Offset = "0x586EB20", VA = "0x18586FF20", Slot = "115")]
		protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x586ED80", Offset = "0x586D980", VA = "0x18586ED80", Slot = "108")]
		public override void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x586FDF0", Offset = "0x586E9F0", VA = "0x18586FDF0", Slot = "120")]
		public override TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x586E3D0", Offset = "0x586CFD0", VA = "0x18586E3D0", Slot = "131")]
		public override void ClearMesh()
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public override event Action<TMP_TextInfo> OnPreRenderText
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x58771E0", Offset = "0x5875DE0", VA = "0x1858771E0", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x58773D0", Offset = "0x5875FD0", VA = "0x1858773D0", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5875C10", Offset = "0x5874810", VA = "0x185875C10", Slot = "109")]
		public override void UpdateGeometry(Mesh mesh, int index)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x58767C0", Offset = "0x58753C0", VA = "0x1858767C0", Slot = "110")]
		public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5876A10", Offset = "0x5875610", VA = "0x185876A10", Slot = "111")]
		public override void UpdateVertexData()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5875BD0", Offset = "0x58747D0", VA = "0x185875BD0")]
		public void UpdateFontAsset()
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x586DF50", Offset = "0x586CB50", VA = "0x18586DF50", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5870DB0", Offset = "0x586F9B0", VA = "0x185870DB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5870BF0", Offset = "0x586F7F0", VA = "0x185870BF0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x5870A10", Offset = "0x586F610", VA = "0x185870A10", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x58701D0", Offset = "0x586EDD0", VA = "0x1858701D0", Slot = "91")]
		protected override void LoadFontAsset()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x586F140", Offset = "0x586DD40", VA = "0x18586F140")]
		private Canvas GetCanvas()
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x58758F0", Offset = "0x58744F0", VA = "0x1858758F0")]
		private void UpdateEnvMapMatrix()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x586EB30", Offset = "0x586D730", VA = "0x18586EB30")]
		private void EnableMasking()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void DisableMasking()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5875CA0", Offset = "0x58748A0", VA = "0x185875CA0")]
		private void UpdateMask()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x586F620", Offset = "0x586E220", VA = "0x18586F620", Slot = "93")]
		protected override Material GetMaterial(Material mat)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x586F7E0", Offset = "0x586E3E0", VA = "0x18586F7E0", Slot = "97")]
		protected override Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5875050", Offset = "0x5873C50", VA = "0x185875050", Slot = "92")]
		protected override void SetSharedMaterial(Material mat)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x586FB40", Offset = "0x586E740", VA = "0x18586FB40", Slot = "95")]
		protected override Material[] GetSharedMaterials()
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x58750D0", Offset = "0x5873CD0", VA = "0x1858750D0", Slot = "96")]
		protected override void SetSharedMaterials(Material[] materials)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5874C00", Offset = "0x5873800", VA = "0x185874C00", Slot = "101")]
		protected override void SetOutlineThickness(float thickness)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x58745C0", Offset = "0x58731C0", VA = "0x1858745C0", Slot = "99")]
		protected override void SetFaceColor(Color32 color)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x5874A30", Offset = "0x5873630", VA = "0x185874A30", Slot = "100")]
		protected override void SetOutlineColor(Color32 color)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x5874F00", Offset = "0x5873B00", VA = "0x185874F00", Slot = "102")]
		protected override void SetShaderDepth()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x58741D0", Offset = "0x5872DD0", VA = "0x1858741D0", Slot = "103")]
		protected override void SetCulling()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x5874E40", Offset = "0x5873A40", VA = "0x185874E40")]
		private void SetPerspectiveCorrection()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x5874970", Offset = "0x5873570", VA = "0x185874970")]
		private void SetMeshArrays(int size)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x5871A00", Offset = "0x5870600", VA = "0x185871A00", Slot = "116")]
		internal override int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars)
		{
			return 0;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x586E500", Offset = "0x586D100", VA = "0x18586E500", Slot = "121")]
		public override void ComputeMarginSize()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x5870B90", Offset = "0x586F790", VA = "0x185870B90", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x58708E0", Offset = "0x586F4E0", VA = "0x1858708E0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x58716F0", Offset = "0x58702F0", VA = "0x1858716F0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5871350", Offset = "0x586FF50", VA = "0x185871350", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5870110", Offset = "0x586ED10", VA = "0x185870110", Slot = "134")]
		internal override void InternalUpdate()
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5871070", Offset = "0x586FC70", VA = "0x185871070")]
		private void OnPreRenderCanvas()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x585E9F0", Offset = "0x585D5F0", VA = "0x18585E9F0", Slot = "144")]
		protected virtual void GenerateTextMesh()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x586FD30", Offset = "0x586E930", VA = "0x18586FD30", Slot = "107")]
		protected override Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5871840", Offset = "0x5870440", VA = "0x185871840", Slot = "129")]
		protected override void SetActiveSubMeshes(bool state)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x586EA20", Offset = "0x586D620", VA = "0x18586EA20", Slot = "130")]
		protected override void DestroySubMeshObjects()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x586F290", Offset = "0x586DE90", VA = "0x18586F290", Slot = "118")]
		protected override Bounds GetCompoundBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x586EE40", Offset = "0x586DA40", VA = "0x18586EE40", Slot = "119")]
		internal override Rect GetCanvasSpaceClippingRect()
		{
			return default(Rect);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5876400", Offset = "0x5875000", VA = "0x185876400")]
		private void UpdateSDFScale(float scaleDelta)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5877120", Offset = "0x5875D20", VA = "0x185877120")]
		public TextMeshProUGUI()
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x6D8")]
		private bool m_isRebuildingLayout;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x6E0")]
		private Coroutine m_DelayedGraphicRebuild;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x6E8")]
		private Coroutine m_DelayedMaterialRebuild;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x6F0")]
		private Rect m_ClipRect;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x700")]
		private bool m_ValidRect;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x710")]
		[SerializeField]
		private bool m_hasFontAssetChanged;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x718")]
		protected TMP_SubMeshUI[] m_subTextObjects;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x720")]
		private float m_previousLossyScaleY;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x728")]
		private Vector3[] m_RectTransformCorners;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x730")]
		private CanvasRenderer m_canvasRenderer;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x738")]
		private Canvas m_canvas;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x740")]
		private float m_CanvasScaleFactor;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x744")]
		private bool m_isFirstAllocation;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x748")]
		private int m_max_characters;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x750")]
		[SerializeField]
		private Material m_baseMaterial;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x758")]
		private bool m_isScrollRegionSet;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x75C")]
		[SerializeField]
		private Vector4 m_maskOffset;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x76C")]
		private Matrix4x4 m_EnvMapMatrix;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x7AC")]
		[NonSerialized]
		private bool m_isRegisteredForEvents;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_GenerateTextMarker;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_SetArraySizesMarker;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_GenerateTextPhaseIMarker;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_ParseMarkupTextMarker;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_CharacterLookupMarker;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_HandleGPOSFeaturesMarker;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_CalculateVerticesPositionMarker;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker k_ComputeTextMetricsMarker;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker k_HandleVisibleCharacterMarker;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker k_HandleWhiteSpacesMarker;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker k_HandleHorizontalLineBreakingMarker;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x58")]
		private static ProfilerMarker k_HandleVerticalLineBreakingMarker;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x60")]
		private static ProfilerMarker k_SaveGlyphVertexDataMarker;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x68")]
		private static ProfilerMarker k_ComputeCharacterAdvanceMarker;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x70")]
		private static ProfilerMarker k_HandleCarriageReturnMarker;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x78")]
		private static ProfilerMarker k_HandleLineTerminationMarker;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x80")]
		private static ProfilerMarker k_SavePageInfoMarker;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x88")]
		private static ProfilerMarker k_SaveProcessingStatesMarker;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x90")]
		private static ProfilerMarker k_GenerateTextPhaseIIMarker;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x98")]
		private static ProfilerMarker k_GenerateTextPhaseIIIMarker;
	}
}
