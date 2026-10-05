using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002046 RID: 8262
	[Token(Token = "0x2002046")]
	[ExecuteInEditMode]
	public class SceneAddLight : BaseSceneEffect, IHotfixable
	{
		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600CB97 RID: 52119 RVA: 0x00049998 File Offset: 0x00047B98
		[Token(Token = "0x17001823")]
		private bool addLightEnabled
		{
			[Token(Token = "0x600CB97")]
			[Address(RVA = "0x34C9860", Offset = "0x34C8460", VA = "0x1834C9860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x0600CB98 RID: 52120 RVA: 0x000499B0 File Offset: 0x00047BB0
		[Token(Token = "0x17001824")]
		private int lightNum
		{
			[Token(Token = "0x600CB98")]
			[Address(RVA = "0x34C99B0", Offset = "0x34C85B0", VA = "0x1834C99B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600CB99 RID: 52121 RVA: 0x000499C8 File Offset: 0x00047BC8
		[Token(Token = "0x17001825")]
		private bool lightCookieEnabled
		{
			[Token(Token = "0x600CB99")]
			[Address(RVA = "0x34C9900", Offset = "0x34C8500", VA = "0x1834C9900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB9A")]
		[Address(RVA = "0x34C80B0", Offset = "0x34C6CB0", VA = "0x1834C80B0")]
		private void _Init()
		{
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB9B")]
		[Address(RVA = "0x34C84B0", Offset = "0x34C70B0", VA = "0x1834C84B0")]
		private void _UpdateLight()
		{
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x000499E0 File Offset: 0x00047BE0
		[Token(Token = "0x600CB9C")]
		[Address(RVA = "0x34C7B40", Offset = "0x34C6740", VA = "0x1834C7B40")]
		private int CheckCookiesInstance(int index)
		{
			return 0;
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x000499F8 File Offset: 0x00047BF8
		[Token(Token = "0x600CB9D")]
		[Address(RVA = "0x34C7A10", Offset = "0x34C6610", VA = "0x1834C7A10")]
		private Vector4 CalculateSpotData(float innerSpotAngle, float outerSpotAngle, LightType type)
		{
			return default(Vector4);
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x00049A10 File Offset: 0x00047C10
		[Token(Token = "0x600CB9E")]
		[Address(RVA = "0x34C7E40", Offset = "0x34C6A40", VA = "0x1834C7E40")]
		private bool _GetCookieAtlasTexture(Texture2D[] cookies, ref RenderTexture target)
		{
			return default(bool);
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB9F")]
		[Address(RVA = "0x34C7DC0", Offset = "0x34C69C0", VA = "0x1834C7DC0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA0")]
		[Address(RVA = "0x34C7CD0", Offset = "0x34C68D0", VA = "0x1834C7CD0", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA1")]
		[Address(RVA = "0x34C7C50", Offset = "0x34C6850", VA = "0x1834C7C50", Slot = "8")]
		public override void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x0600CBA2 RID: 52130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA2")]
		[Address(RVA = "0x34C96A0", Offset = "0x34C82A0", VA = "0x1834C96A0")]
		public SceneAddLight()
		{
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA4")]
		[Address(RVA = "0x34BE730", Offset = "0x34BD330", VA = "0x1834BE730")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CBA5 RID: 52133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA5")]
		[Address(RVA = "0x34BE6D0", Offset = "0x34BD2D0", VA = "0x1834BE6D0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600CBA6 RID: 52134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA6")]
		[Address(RVA = "0x34BE5F0", Offset = "0x34BD1F0", VA = "0x1834BE5F0")]
		private void <>xLuaBaseProxy_Merge(BaseSceneEffect P0)
		{
		}

		// Token: 0x0400D5D4 RID: 54740
		[Token(Token = "0x400D5D4")]
		private const int RUNTIME_FIXED_LIGHT_NUM = 8;

		// Token: 0x0400D5D5 RID: 54741
		[Token(Token = "0x400D5D5")]
		private const int RUNTIME_LIGHT_COOKIE_NUM = 4;

		// Token: 0x0400D5D6 RID: 54742
		[Token(Token = "0x400D5D6")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture cookiesRT;

		// Token: 0x0400D5D7 RID: 54743
		[Token(Token = "0x400D5D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private bool _needUpdate;

		// Token: 0x0400D5D8 RID: 54744
		[Token(Token = "0x400D5D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Light[] _addtionalLights;

		// Token: 0x0400D5D9 RID: 54745
		[Token(Token = "0x400D5D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Shader _lightCookieMergeShader;

		// Token: 0x0400D5DA RID: 54746
		[Token(Token = "0x400D5DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public SceneAddLight.SpotLightConfig[] spotConfig;

		// Token: 0x0400D5DB RID: 54747
		[Token(Token = "0x400D5DB")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private bool m_inited;

		// Token: 0x0400D5DC RID: 54748
		[Token(Token = "0x400D5DC")]
		[FieldOffset(Offset = "0x4C")]
		private int m_cookiesNum;

		// Token: 0x0400D5DD RID: 54749
		[Token(Token = "0x400D5DD")]
		[FieldOffset(Offset = "0x50")]
		private Material m_mergeMat;

		// Token: 0x0400D5DE RID: 54750
		[Token(Token = "0x400D5DE")]
		[FieldOffset(Offset = "0x58")]
		private SceneAddLight.AddLight[] m_addLightData;

		// Token: 0x0400D5DF RID: 54751
		[Token(Token = "0x400D5DF")]
		[FieldOffset(Offset = "0x60")]
		private Vector4[] m_lightList;

		// Token: 0x0400D5E0 RID: 54752
		[Token(Token = "0x400D5E0")]
		[FieldOffset(Offset = "0x68")]
		private Vector4[] m_lightPosList;

		// Token: 0x0400D5E1 RID: 54753
		[Token(Token = "0x400D5E1")]
		[FieldOffset(Offset = "0x70")]
		private Vector4[] m_lightAngleList;

		// Token: 0x0400D5E2 RID: 54754
		[Token(Token = "0x400D5E2")]
		[FieldOffset(Offset = "0x78")]
		private Vector4[] m_lightDirList;

		// Token: 0x0400D5E3 RID: 54755
		[Token(Token = "0x400D5E3")]
		[FieldOffset(Offset = "0x80")]
		private Matrix4x4[] m_worldToLight;

		// Token: 0x0400D5E4 RID: 54756
		[Token(Token = "0x400D5E4")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D[] m_lightCookies;

		// Token: 0x0400D5E5 RID: 54757
		[Token(Token = "0x400D5E5")]
		[FieldOffset(Offset = "0x90")]
		private int[] m_cookiesInstanceIDs;

		// Token: 0x0400D5E6 RID: 54758
		[Token(Token = "0x400D5E6")]
		[FieldOffset(Offset = "0x98")]
		private Vector4[] m_lightCookieIDs;

		// Token: 0x0400D5E7 RID: 54759
		[Token(Token = "0x400D5E7")]
		[FieldOffset(Offset = "0xA0")]
		private int m_addLightColorArrID;

		// Token: 0x0400D5E8 RID: 54760
		[Token(Token = "0x400D5E8")]
		[FieldOffset(Offset = "0xA4")]
		private int m_addLightPosArrID;

		// Token: 0x0400D5E9 RID: 54761
		[Token(Token = "0x400D5E9")]
		[FieldOffset(Offset = "0xA8")]
		private int m_addLightNumID;

		// Token: 0x0400D5EA RID: 54762
		[Token(Token = "0x400D5EA")]
		[FieldOffset(Offset = "0xAC")]
		private int m_addLightAngleID;

		// Token: 0x0400D5EB RID: 54763
		[Token(Token = "0x400D5EB")]
		[FieldOffset(Offset = "0xB0")]
		private int m_addLightDirID;

		// Token: 0x0400D5EC RID: 54764
		[Token(Token = "0x400D5EC")]
		[FieldOffset(Offset = "0xB4")]
		private int m_addLightCookie;

		// Token: 0x0400D5ED RID: 54765
		[Token(Token = "0x400D5ED")]
		[FieldOffset(Offset = "0xB8")]
		private int m_addWorldToLight;

		// Token: 0x0400D5EE RID: 54766
		[Token(Token = "0x400D5EE")]
		[FieldOffset(Offset = "0xBC")]
		private int m_addLightCookieID;

		// Token: 0x0400D5EF RID: 54767
		[Token(Token = "0x400D5EF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] cookiesName;

		// Token: 0x0400D5F0 RID: 54768
		[Token(Token = "0x400D5F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_addLightEnabled;

		// Token: 0x0400D5F1 RID: 54769
		[Token(Token = "0x400D5F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lightNum;

		// Token: 0x0400D5F2 RID: 54770
		[Token(Token = "0x400D5F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_lightCookieEnabled;

		// Token: 0x0400D5F3 RID: 54771
		[Token(Token = "0x400D5F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400D5F4 RID: 54772
		[Token(Token = "0x400D5F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateLight;

		// Token: 0x0400D5F5 RID: 54773
		[Token(Token = "0x400D5F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckCookiesInstance;

		// Token: 0x0400D5F6 RID: 54774
		[Token(Token = "0x400D5F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CalculateSpotData;

		// Token: 0x0400D5F7 RID: 54775
		[Token(Token = "0x400D5F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetCookieAtlasTexture;

		// Token: 0x0400D5F8 RID: 54776
		[Token(Token = "0x400D5F8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D5F9 RID: 54777
		[Token(Token = "0x400D5F9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D5FA RID: 54778
		[Token(Token = "0x400D5FA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D5FB RID: 54779
		[Token(Token = "0x400D5FB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002047 RID: 8263
		[Token(Token = "0x2002047")]
		public struct AddLight
		{
			// Token: 0x0400D5FC RID: 54780
			[Token(Token = "0x400D5FC")]
			[FieldOffset(Offset = "0x0")]
			public Color color;

			// Token: 0x0400D5FD RID: 54781
			[Token(Token = "0x400D5FD")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 position;

			// Token: 0x0400D5FE RID: 54782
			[Token(Token = "0x400D5FE")]
			[FieldOffset(Offset = "0x1C")]
			public float intensity;

			// Token: 0x0400D5FF RID: 54783
			[Token(Token = "0x400D5FF")]
			[FieldOffset(Offset = "0x20")]
			public float range;

			// Token: 0x0400D600 RID: 54784
			[Token(Token = "0x400D600")]
			[FieldOffset(Offset = "0x24")]
			public float spotAngle;

			// Token: 0x0400D601 RID: 54785
			[Token(Token = "0x400D601")]
			[FieldOffset(Offset = "0x28")]
			public Vector4 direction;

			// Token: 0x0400D602 RID: 54786
			[Token(Token = "0x400D602")]
			[FieldOffset(Offset = "0x38")]
			public LightType type;

			// Token: 0x0400D603 RID: 54787
			[Token(Token = "0x400D603")]
			[FieldOffset(Offset = "0x40")]
			public Texture cookie;

			// Token: 0x0400D604 RID: 54788
			[Token(Token = "0x400D604")]
			[FieldOffset(Offset = "0x48")]
			public Matrix4x4 worldToLight;

			// Token: 0x0400D605 RID: 54789
			[Token(Token = "0x400D605")]
			[FieldOffset(Offset = "0x88")]
			public int cookieID;
		}

		// Token: 0x02002048 RID: 8264
		[Token(Token = "0x2002048")]
		[Serializable]
		public struct SpotLightConfig
		{
			// Token: 0x0600CBA7 RID: 52135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CBA7")]
			[Address(RVA = "0x34CE350", Offset = "0x34CCF50", VA = "0x1834CE350")]
			public SpotLightConfig(bool uniform, int index)
			{
			}

			// Token: 0x0400D606 RID: 54790
			[Token(Token = "0x400D606")]
			[FieldOffset(Offset = "0x0")]
			public bool isUniform;

			// Token: 0x0400D607 RID: 54791
			[Token(Token = "0x400D607")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 7f)]
			public int lightIndex;
		}
	}
}
