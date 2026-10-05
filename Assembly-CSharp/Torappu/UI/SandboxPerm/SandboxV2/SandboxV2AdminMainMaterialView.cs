using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004076 RID: 16502
	[Token(Token = "0x2004076")]
	public class SandboxV2AdminMainMaterialView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019867 RID: 104551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019867")]
		[Address(RVA = "0x1230240", Offset = "0x122EE40", VA = "0x181230240")]
		public void Render(string topicId, SandboxV2AdminMainMaterialModel model)
		{
		}

		// Token: 0x06019868 RID: 104552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019868")]
		[Address(RVA = "0x12306B0", Offset = "0x122F2B0", VA = "0x1812306B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019869 RID: 104553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019869")]
		[Address(RVA = "0x12307C0", Offset = "0x122F3C0", VA = "0x1812307C0")]
		public SandboxV2AdminMainMaterialView()
		{
		}

		// Token: 0x0401FD18 RID: 130328
		[Token(Token = "0x401FD18")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0401FD19 RID: 130329
		[Token(Token = "0x401FD19")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0401FD1A RID: 130330
		[Token(Token = "0x401FD1A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SandboxV2AdminMainMaterialView.ColorConfig> _colorConfigs;

		// Token: 0x0401FD1B RID: 130331
		[Token(Token = "0x401FD1B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _validAlpha;

		// Token: 0x0401FD1C RID: 130332
		[Token(Token = "0x401FD1C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _invalidAlpha;

		// Token: 0x0401FD1D RID: 130333
		[Token(Token = "0x401FD1D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _validCountColor;

		// Token: 0x0401FD1E RID: 130334
		[Token(Token = "0x401FD1E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _invalidCountColor;

		// Token: 0x0401FD1F RID: 130335
		[Token(Token = "0x401FD1F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0401FD20 RID: 130336
		[Token(Token = "0x401FD20")]
		[FieldOffset(Offset = "0x60")]
		private readonly Dictionary<SandboxV2AdminMainMaterialModel.ColorType, Color> m_colorOfTypes;

		// Token: 0x0401FD21 RID: 130337
		[Token(Token = "0x401FD21")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_finder;

		// Token: 0x0401FD22 RID: 130338
		[Token(Token = "0x401FD22")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedId;

		// Token: 0x0401FD23 RID: 130339
		[Token(Token = "0x401FD23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FD24 RID: 130340
		[Token(Token = "0x401FD24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FD25 RID: 130341
		[Token(Token = "0x401FD25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004077 RID: 16503
		[Token(Token = "0x2004077")]
		[Serializable]
		public struct ColorConfig
		{
			// Token: 0x0401FD26 RID: 130342
			[Token(Token = "0x401FD26")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2AdminMainMaterialModel.ColorType type;

			// Token: 0x0401FD27 RID: 130343
			[Token(Token = "0x401FD27")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}
	}
}
