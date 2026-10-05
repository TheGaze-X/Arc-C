using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006925 RID: 26917
	[Token(Token = "0x2006925")]
	public abstract class StagePreviewDynHolder<T> : DataBinder<ZoneViewProperty>, IHotfixable where T : StagePreviewInfoBasicPanel
	{
		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x060268D9 RID: 157913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B08")]
		public StagePreviewConfigController previewConfigController
		{
			[Token(Token = "0x60268D9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060268DA RID: 157914
		[Token(Token = "0x60268DA")]
		protected abstract bool SelectStageViewModel(ZoneViewModel zoneModel, out StageViewModel stageModel);

		// Token: 0x060268DB RID: 157915
		[Token(Token = "0x60268DB")]
		protected abstract string GetPrefabPath();

		// Token: 0x060268DC RID: 157916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268DC")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x060268DD RID: 157917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268DD")]
		public void CloseTips()
		{
		}

		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x060268DE RID: 157918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B09")]
		protected Transform container
		{
			[Token(Token = "0x60268DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x060268DF RID: 157919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B0A")]
		public T InfoPanel
		{
			[Token(Token = "0x60268DF")]
			get
			{
				return null;
			}
		}

		// Token: 0x060268E0 RID: 157920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268E0")]
		protected StagePreviewDynHolder()
		{
		}

		// Token: 0x040365FF RID: 222719
		[Token(Token = "0x40365FF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _prefabContainer;

		// Token: 0x04036600 RID: 222720
		[Token(Token = "0x4036600")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _mapTips;

		// Token: 0x04036601 RID: 222721
		[Token(Token = "0x4036601")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Image _imageMapTips;

		// Token: 0x04036602 RID: 222722
		[Token(Token = "0x4036602")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Image _backTips;

		// Token: 0x04036603 RID: 222723
		[Token(Token = "0x4036603")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _mapPreviewPluginContainer;

		// Token: 0x04036604 RID: 222724
		[Token(Token = "0x4036604")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _displayMetaPluginContainer;

		// Token: 0x04036605 RID: 222725
		[Token(Token = "0x4036605")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _mapTipsRect;

		// Token: 0x04036606 RID: 222726
		[Token(Token = "0x4036606")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _mapPreviewNormalSize;

		// Token: 0x04036607 RID: 222727
		[Token(Token = "0x4036607")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _mapPreviewSpecialBound;

		// Token: 0x04036608 RID: 222728
		[Token(Token = "0x4036608")]
		[FieldOffset(Offset = "0x0")]
		private T m_infoPanel;

		// Token: 0x04036609 RID: 222729
		[Token(Token = "0x4036609")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_previewConfigController;

		// Token: 0x0403660A RID: 222730
		[Token(Token = "0x403660A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x0403660B RID: 222731
		[Token(Token = "0x403660B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CloseTips;

		// Token: 0x0403660C RID: 222732
		[Token(Token = "0x403660C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_container;

		// Token: 0x0403660D RID: 222733
		[Token(Token = "0x403660D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_InfoPanel;

		// Token: 0x0403660E RID: 222734
		[Token(Token = "0x403660E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
