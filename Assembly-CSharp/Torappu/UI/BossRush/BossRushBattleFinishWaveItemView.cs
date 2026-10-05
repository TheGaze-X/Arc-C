using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006162 RID: 24930
	[Token(Token = "0x2006162")]
	public class BossRushBattleFinishWaveItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023FCF RID: 147407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FCF")]
		[Address(RVA = "0x1EA25A0", Offset = "0x1EA11A0", VA = "0x181EA25A0")]
		public void Render(int currentWave, bool isFinalWave, bool isLastWave)
		{
		}

		// Token: 0x06023FD0 RID: 147408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FD0")]
		[Address(RVA = "0x1EA2900", Offset = "0x1EA1500", VA = "0x181EA2900")]
		public BossRushBattleFinishWaveItemView()
		{
		}

		// Token: 0x04031FE1 RID: 204769
		[Token(Token = "0x4031FE1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textWave;

		// Token: 0x04031FE2 RID: 204770
		[Token(Token = "0x4031FE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgCaption;

		// Token: 0x04031FE3 RID: 204771
		[Token(Token = "0x4031FE3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _finalWaveBg;

		// Token: 0x04031FE4 RID: 204772
		[Token(Token = "0x4031FE4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalWaveBg;

		// Token: 0x04031FE5 RID: 204773
		[Token(Token = "0x4031FE5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorFinal;

		// Token: 0x04031FE6 RID: 204774
		[Token(Token = "0x4031FE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorNormnal;

		// Token: 0x04031FE7 RID: 204775
		[Token(Token = "0x4031FE7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _alphaNotLast;

		// Token: 0x04031FE8 RID: 204776
		[Token(Token = "0x4031FE8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _bossIconGo;

		// Token: 0x04031FE9 RID: 204777
		[Token(Token = "0x4031FE9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _iconBoss;

		// Token: 0x04031FEA RID: 204778
		[Token(Token = "0x4031FEA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _bossIconList;

		// Token: 0x04031FEB RID: 204779
		[Token(Token = "0x4031FEB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorNormalBossIcon;

		// Token: 0x04031FEC RID: 204780
		[Token(Token = "0x4031FEC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorFinalBossIcon;

		// Token: 0x04031FED RID: 204781
		[Token(Token = "0x4031FED")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _alphaBossIcon;

		// Token: 0x04031FEE RID: 204782
		[Token(Token = "0x4031FEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031FEF RID: 204783
		[Token(Token = "0x4031FEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006163 RID: 24931
		[Token(Token = "0x2006163")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06023FD1 RID: 147409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023FD1")]
			[Address(RVA = "0x1E9DD90", Offset = "0x1E9C990", VA = "0x181E9DD90")]
			public Adapter(int waveCount, Color themeColor, float startAlpha)
			{
			}

			// Token: 0x170054F7 RID: 21751
			// (get) Token: 0x06023FD2 RID: 147410 RVA: 0x000C2AF0 File Offset: 0x000C0CF0
			[Token(Token = "0x170054F7")]
			public override int count
			{
				[Token(Token = "0x6023FD2")]
				[Address(RVA = "0x1E9DE40", Offset = "0x1E9CA40", VA = "0x181E9DE40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023FD3 RID: 147411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023FD3")]
			[Address(RVA = "0x1E9D7B0", Offset = "0x1E9C3B0", VA = "0x181E9D7B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031FF0 RID: 204784
			[Token(Token = "0x4031FF0")]
			[FieldOffset(Offset = "0x20")]
			private int m_waveCount;

			// Token: 0x04031FF1 RID: 204785
			[Token(Token = "0x4031FF1")]
			[FieldOffset(Offset = "0x24")]
			private Color m_themeColor;

			// Token: 0x04031FF2 RID: 204786
			[Token(Token = "0x4031FF2")]
			[FieldOffset(Offset = "0x34")]
			private float m_startAlpha;

			// Token: 0x04031FF3 RID: 204787
			[Token(Token = "0x4031FF3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031FF4 RID: 204788
			[Token(Token = "0x4031FF4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031FF5 RID: 204789
			[Token(Token = "0x4031FF5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
