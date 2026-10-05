using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Particle;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	[RequireComponent(typeof(CanvasRenderer))]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class UIParticleRenderer : MaskableGraphic
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CD")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x5543E80", Offset = "0x5542A80", VA = "0x185543E80", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00006F44 File Offset: 0x00005144
		[Token(Token = "0x170000CE")]
		public override bool raycastTarget
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00006F5C File Offset: 0x0000515C
		[Token(Token = "0x170000CF")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x5543EA0", Offset = "0x5542AA0", VA = "0x185543EA0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5542100", Offset = "0x5540D00", VA = "0x185542100")]
		public void Reset(int index = -1)
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x5541710", Offset = "0x5540310", VA = "0x185541710")]
		public static UIParticleRenderer AddRenderer(UIParticle parent, int index)
		{
			return null;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "60")]
		public override Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x5542270", Offset = "0x5540E70", VA = "0x185542270")]
		public void Set(UIParticle parent, UIParticle.ParticleContext psContext, bool isTrail, bool isDriver)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x55420A0", Offset = "0x5540CA0", VA = "0x1855420A0")]
		public void NotifyTextureSheetAnimationFrameOverTimeChanged()
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x55425B0", Offset = "0x55411B0", VA = "0x1855425B0")]
		public void UpdateMesh(Camera bakeCamera)
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x55419E0", Offset = "0x55405E0", VA = "0x1855419E0", Slot = "61")]
		public override void Cull(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00006F74 File Offset: 0x00005174
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x5541F20", Offset = "0x5540B20", VA = "0x185541F20")]
		private Vector3 GetWorldScale()
		{
			return default(Vector3);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00006F8C File Offset: 0x0000518C
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x5541BF0", Offset = "0x55407F0", VA = "0x185541BF0")]
		private Matrix4x4 GetWorldMatrix(Vector3 psPos, Vector3 scale)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x55438E0", Offset = "0x55424E0", VA = "0x1855438E0")]
		private void _Simulate(Vector3 scale, bool paused)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00006FA4 File Offset: 0x000051A4
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x5543830", Offset = "0x5542430", VA = "0x185543830")]
		private ParticleGeometryUtils.BakeInput _CreateBakeInput(Camera bakeCamera)
		{
			return default(ParticleGeometryUtils.BakeInput);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x5543E70", Offset = "0x5542A70", VA = "0x185543E70")]
		public UIParticleRenderer()
		{
		}

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Component> s_components;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly CombineInstance[] s_combineInstances;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<UIParticleRenderer> s_renderers;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<Color32> s_colors;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector3[] s_corners;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x28")]
		private static bool s_globalDisableCulling;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_delay;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0xEC")]
		private int m_index;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isTrail;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0xF4")]
		private Bounds m_lastBounds;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x110")]
		private UIParticle m_parent;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x118")]
		private ParticleSystem m_particleSystem;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x120")]
		private float m_prevCanvasScale;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 m_prevPsPos;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 m_prevScale;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x13C")]
		private Vector2Int m_prevScreenSize;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x144")]
		private bool m_prewarm;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x148")]
		private ParticleSystemRenderer m_renderer;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x150")]
		private UIParticle.ParticleContext m_psContext;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x158")]
		private bool m_isParticleDriver;
	}
}
