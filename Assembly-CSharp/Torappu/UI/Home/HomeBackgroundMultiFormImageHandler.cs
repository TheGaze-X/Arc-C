using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B3E RID: 19262
	[Token(Token = "0x2004B3E")]
	public class HomeBackgroundMultiFormImageHandler : MonoBehaviour, IMultiFormHandler, IHotfixable
	{
		// Token: 0x0601D058 RID: 118872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D058")]
		[Address(RVA = "0x1668CB0", Offset = "0x16678B0", VA = "0x181668CB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D059")]
		[Address(RVA = "0x1668D10", Offset = "0x1667910", VA = "0x181668D10", Slot = "4")]
		public void OnMultiFormChanged(HomeDisplayMultiFormItemModel formModel, bool shouldReset)
		{
		}

		// Token: 0x0601D05A RID: 118874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D05A")]
		[Address(RVA = "0x1668BE0", Offset = "0x16677E0", VA = "0x181668BE0")]
		public void ClearAll()
		{
		}

		// Token: 0x0601D05B RID: 118875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D05B")]
		[Address(RVA = "0x1669230", Offset = "0x1667E30", VA = "0x181669230")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D05C RID: 118876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D05C")]
		[Address(RVA = "0x1669330", Offset = "0x1667F30", VA = "0x181669330")]
		private void _LoadAssetsIfNecessary(string mainId, bool isMultiForm)
		{
		}

		// Token: 0x0601D05D RID: 118877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D05D")]
		private T _LoadAsset<T>(string resPath) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0601D05E RID: 118878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D05E")]
		private void _UnloadAsset<T>(T asset) where T : UnityEngine.Object
		{
		}

		// Token: 0x0601D05F RID: 118879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D05F")]
		[Address(RVA = "0x16694B0", Offset = "0x16680B0", VA = "0x1816694B0")]
		private void _PlayBackgroundMusic(string bgMusicId)
		{
		}

		// Token: 0x0601D060 RID: 118880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D060")]
		[Address(RVA = "0x16695F0", Offset = "0x16681F0", VA = "0x1816695F0")]
		private void _ResetToState(string formId)
		{
		}

		// Token: 0x0601D061 RID: 118881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D061")]
		[Address(RVA = "0x1669890", Offset = "0x1668490", VA = "0x181669890")]
		private void _TransToState(string formId)
		{
		}

		// Token: 0x0601D062 RID: 118882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D062")]
		[Address(RVA = "0x16696E0", Offset = "0x16682E0", VA = "0x1816696E0")]
		private void _SetSprites()
		{
		}

		// Token: 0x0601D063 RID: 118883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D063")]
		[Address(RVA = "0x1669800", Offset = "0x1668400", VA = "0x181669800")]
		private void _StopAllAnim()
		{
		}

		// Token: 0x0601D064 RID: 118884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D064")]
		[Address(RVA = "0x1669A60", Offset = "0x1668660", VA = "0x181669A60")]
		public HomeBackgroundMultiFormImageHandler()
		{
		}

		// Token: 0x04026117 RID: 155927
		[Token(Token = "0x4026117")]
		private const float DEFAULT_MULTI_FORM_TRANS_DURATION = 3f;

		// Token: 0x04026118 RID: 155928
		[Token(Token = "0x4026118")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _fromFormImgLeft;

		// Token: 0x04026119 RID: 155929
		[Token(Token = "0x4026119")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _fromFormImgRight;

		// Token: 0x0402611A RID: 155930
		[Token(Token = "0x402611A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _toFormImgLeft;

		// Token: 0x0402611B RID: 155931
		[Token(Token = "0x402611B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _toFormImgRight;

		// Token: 0x0402611C RID: 155932
		[Token(Token = "0x402611C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _toFormAlphaHolder;

		// Token: 0x0402611D RID: 155933
		[Token(Token = "0x402611D")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0402611E RID: 155934
		[Token(Token = "0x402611E")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_toTween;

		// Token: 0x0402611F RID: 155935
		[Token(Token = "0x402611F")]
		[FieldOffset(Offset = "0x50")]
		private UIRingStateGraph m_stateGraph;

		// Token: 0x04026120 RID: 155936
		[Token(Token = "0x4026120")]
		[FieldOffset(Offset = "0x58")]
		private HomeBackgroundAssetsWrapper m_cachedBgAssets;

		// Token: 0x04026121 RID: 155937
		[Token(Token = "0x4026121")]
		[FieldOffset(Offset = "0x60")]
		private HomeBackgroundMultiFormImageHandler.SpriteGroup m_fromFormGrp;

		// Token: 0x04026122 RID: 155938
		[Token(Token = "0x4026122")]
		[FieldOffset(Offset = "0x68")]
		private HomeBackgroundMultiFormImageHandler.SpriteGroup m_toFormGrp;

		// Token: 0x04026123 RID: 155939
		[Token(Token = "0x4026123")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedMainId;

		// Token: 0x04026124 RID: 155940
		[Token(Token = "0x4026124")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedFormId;

		// Token: 0x04026125 RID: 155941
		[Token(Token = "0x4026125")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedMusicId;

		// Token: 0x04026126 RID: 155942
		[Token(Token = "0x4026126")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04026127 RID: 155943
		[Token(Token = "0x4026127")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMultiFormChanged;

		// Token: 0x04026128 RID: 155944
		[Token(Token = "0x4026128")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearAll;

		// Token: 0x04026129 RID: 155945
		[Token(Token = "0x4026129")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402612A RID: 155946
		[Token(Token = "0x402612A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadAssetsIfNecessary;

		// Token: 0x0402612B RID: 155947
		[Token(Token = "0x402612B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadAsset;

		// Token: 0x0402612C RID: 155948
		[Token(Token = "0x402612C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UnloadAsset;

		// Token: 0x0402612D RID: 155949
		[Token(Token = "0x402612D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayBackgroundMusic;

		// Token: 0x0402612E RID: 155950
		[Token(Token = "0x402612E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ResetToState;

		// Token: 0x0402612F RID: 155951
		[Token(Token = "0x402612F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TransToState;

		// Token: 0x04026130 RID: 155952
		[Token(Token = "0x4026130")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetSprites;

		// Token: 0x04026131 RID: 155953
		[Token(Token = "0x4026131")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__StopAllAnim;

		// Token: 0x04026132 RID: 155954
		[Token(Token = "0x4026132")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B3F RID: 19263
		[Token(Token = "0x2004B3F")]
		private class SpriteGroup
		{
			// Token: 0x17004445 RID: 17477
			// (get) Token: 0x0601D065 RID: 118885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004445")]
			public Sprite imgLeft
			{
				[Token(Token = "0x601D065")]
				[Address(RVA = "0x167AE10", Offset = "0x1679A10", VA = "0x18167AE10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17004446 RID: 17478
			// (get) Token: 0x0601D066 RID: 118886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004446")]
			public Sprite imgRight
			{
				[Token(Token = "0x601D066")]
				[Address(RVA = "0x167AE20", Offset = "0x1679A20", VA = "0x18167AE20")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601D067 RID: 118887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D067")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public SpriteGroup(HomeBackgroundMultiFormImageHandler closure)
			{
			}

			// Token: 0x0601D068 RID: 118888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D068")]
			[Address(RVA = "0x167AD30", Offset = "0x1679930", VA = "0x18167AD30")]
			public void Load(string formId)
			{
			}

			// Token: 0x0601D069 RID: 118889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D069")]
			[Address(RVA = "0x167AD80", Offset = "0x1679980", VA = "0x18167AD80")]
			public void Unload()
			{
			}

			// Token: 0x04026133 RID: 155955
			[Token(Token = "0x4026133")]
			[FieldOffset(Offset = "0x10")]
			private HomeBackgroundMultiFormImageHandler m_closure;

			// Token: 0x04026134 RID: 155956
			[Token(Token = "0x4026134")]
			[FieldOffset(Offset = "0x18")]
			private BackgroundFormAssetWrapper m_wrapper;
		}
	}
}
