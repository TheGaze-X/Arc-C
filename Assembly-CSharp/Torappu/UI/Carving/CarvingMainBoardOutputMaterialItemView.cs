using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006036 RID: 24630
	[Token(Token = "0x2006036")]
	public class CarvingMainBoardOutputMaterialItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060239D8 RID: 145880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D8")]
		[Address(RVA = "0x1E469F0", Offset = "0x1E455F0", VA = "0x181E469F0")]
		public void Render(CarvingMaterialModel model, bool needStopTween, int enterBoardSeqNum)
		{
		}

		// Token: 0x060239D9 RID: 145881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239D9")]
		[Address(RVA = "0x1E46E10", Offset = "0x1E45A10", VA = "0x181E46E10")]
		private void _PlayLightAnim()
		{
		}

		// Token: 0x060239DA RID: 145882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239DA")]
		[Address(RVA = "0x1E46D20", Offset = "0x1E45920", VA = "0x181E46D20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060239DB RID: 145883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239DB")]
		[Address(RVA = "0x1E46F20", Offset = "0x1E45B20", VA = "0x181E46F20")]
		public CarvingMainBoardOutputMaterialItemView()
		{
		}

		// Token: 0x040314F9 RID: 201977
		[Token(Token = "0x40314F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarvingMaterialItem _materialItemPrefab;

		// Token: 0x040314FA RID: 201978
		[Token(Token = "0x40314FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _materialContent;

		// Token: 0x040314FB RID: 201979
		[Token(Token = "0x40314FB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _materialScaler;

		// Token: 0x040314FC RID: 201980
		[Token(Token = "0x40314FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIParticle _uiParticle;

		// Token: 0x040314FD RID: 201981
		[Token(Token = "0x40314FD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _lightAnimLocation;

		// Token: 0x040314FE RID: 201982
		[Token(Token = "0x40314FE")]
		[FieldOffset(Offset = "0x48")]
		private CarvingMaterialItem m_materialItem;

		// Token: 0x040314FF RID: 201983
		[Token(Token = "0x40314FF")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedIconId;

		// Token: 0x04031500 RID: 201984
		[Token(Token = "0x4031500")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedCnt;

		// Token: 0x04031501 RID: 201985
		[Token(Token = "0x4031501")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_isInited;

		// Token: 0x04031502 RID: 201986
		[Token(Token = "0x4031502")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_lightTween;

		// Token: 0x04031503 RID: 201987
		[Token(Token = "0x4031503")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedEnterBoardSeqNum;

		// Token: 0x04031504 RID: 201988
		[Token(Token = "0x4031504")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031505 RID: 201989
		[Token(Token = "0x4031505")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayLightAnim;

		// Token: 0x04031506 RID: 201990
		[Token(Token = "0x4031506")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031507 RID: 201991
		[Token(Token = "0x4031507")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
