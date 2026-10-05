using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Grading;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021A4 RID: 8612
	[Token(Token = "0x20021A4")]
	public class CameraController : SingletonMonoBehaviour<CameraController>, ISingletonNotAutoCreate, ISafeAreaListener, IHotfixable
	{
		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x0004D940 File Offset: 0x0004BB40
		[Token(Token = "0x17001A06")]
		public bool hasPPLayer
		{
			[Token(Token = "0x600D6B0")]
			[Address(RVA = "0x35BD1D0", Offset = "0x35BBDD0", VA = "0x1835BD1D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x0600D6B1 RID: 54961 RVA: 0x0004D958 File Offset: 0x0004BB58
		// (set) Token: 0x0600D6B2 RID: 54962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A07")]
		public MapLayer currentLayer
		{
			[Token(Token = "0x600D6B1")]
			[Address(RVA = "0x35BD170", Offset = "0x35BBD70", VA = "0x1835BD170")]
			[CompilerGenerated]
			get
			{
				return MapLayer.LAYER_A;
			}
			[Token(Token = "0x600D6B2")]
			[Address(RVA = "0x35BD770", Offset = "0x35BC370", VA = "0x1835BD770")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600D6B3 RID: 54963 RVA: 0x0004D970 File Offset: 0x0004BB70
		// (set) Token: 0x0600D6B4 RID: 54964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A08")]
		[Inspect]
		[Group("Layer")]
		public Vector3 originPos
		{
			[Token(Token = "0x600D6B3")]
			[Address(RVA = "0x35BD520", Offset = "0x35BC120", VA = "0x1835BD520")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600D6B4")]
			[Address(RVA = "0x35BD7E0", Offset = "0x35BC3E0", VA = "0x1835BD7E0")]
			private set
			{
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x0004D988 File Offset: 0x0004BB88
		[Token(Token = "0x17001A09")]
		[Inspect]
		[Group("Layer")]
		private MapLayer nextLayer
		{
			[Token(Token = "0x600D6B5")]
			[Address(RVA = "0x35BD3A0", Offset = "0x35BBFA0", VA = "0x1835BD3A0")]
			get
			{
				return MapLayer.LAYER_A;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x0004D9A0 File Offset: 0x0004BBA0
		[Token(Token = "0x17001A0A")]
		[Inspect]
		[Group("Layer")]
		public bool isTweening
		{
			[Token(Token = "0x600D6B6")]
			[Address(RVA = "0x35BD340", Offset = "0x35BBF40", VA = "0x1835BD340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x0600D6B7 RID: 54967 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
		[Token(Token = "0x17001A0B")]
		public bool isMoving
		{
			[Token(Token = "0x600D6B7")]
			[Address(RVA = "0x35BD260", Offset = "0x35BBE60", VA = "0x1835BD260")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x0004D9D0 File Offset: 0x0004BBD0
		[Token(Token = "0x17001A0C")]
		[Inspect]
		[Group("Layer")]
		public bool isScaling
		{
			[Token(Token = "0x600D6B8")]
			[Address(RVA = "0x35BD2D0", Offset = "0x35BBED0", VA = "0x1835BD2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x0600D6B9 RID: 54969 RVA: 0x0004D9E8 File Offset: 0x0004BBE8
		[Token(Token = "0x17001A0D")]
		public CameraController.CameraPosition cameraPosition
		{
			[Token(Token = "0x600D6B9")]
			[Address(RVA = "0x35BD0B0", Offset = "0x35BBCB0", VA = "0x1835BD0B0")]
			get
			{
				return CameraController.CameraPosition.DEFAULT;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x0600D6BA RID: 54970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A0E")]
		public Camera camera
		{
			[Token(Token = "0x600D6BA")]
			[Address(RVA = "0x35BD110", Offset = "0x35BBD10", VA = "0x1835BD110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x0600D6BB RID: 54971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A0F")]
		public Camera uiPerspectiveCamera
		{
			[Token(Token = "0x600D6BB")]
			[Address(RVA = "0x35BD710", Offset = "0x35BC310", VA = "0x1835BD710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D6BD RID: 54973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001A10")]
		public CameraController.Plugin plugin
		{
			[Token(Token = "0x600D6BC")]
			[Address(RVA = "0x35BD6B0", Offset = "0x35BC2B0", VA = "0x1835BD6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D6BD")]
			[Address(RVA = "0x35BD870", Offset = "0x35BC470", VA = "0x1835BD870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x0004DA00 File Offset: 0x0004BC00
		[Token(Token = "0x17001A11")]
		public Vector3 cameraOffset
		{
			[Token(Token = "0x600D6BE")]
			[Address(RVA = "0x35BCEA0", Offset = "0x35BBAA0", VA = "0x1835BCEA0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x0600D6BF RID: 54975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A12")]
		public Transform offsetTransform
		{
			[Token(Token = "0x600D6BF")]
			[Address(RVA = "0x35BD4C0", Offset = "0x35BC0C0", VA = "0x1835BD4C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C0")]
		[Address(RVA = "0x35B95B0", Offset = "0x35B81B0", VA = "0x1835B95B0")]
		public void ResetAll(bool tween = true)
		{
		}

		// Token: 0x0600D6C1 RID: 54977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C1")]
		[Address(RVA = "0x35B9E50", Offset = "0x35B8A50", VA = "0x1835B9E50")]
		public void SetCameraMoveDirectlyDisableState(bool disableState = false)
		{
		}

		// Token: 0x0600D6C2 RID: 54978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C2")]
		[Address(RVA = "0x35BA250", Offset = "0x35B8E50", VA = "0x1835BA250")]
		public void SetPerspectiveCameraOn(CameraController.PerpectiveCameraMask mask, bool isOn)
		{
		}

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C3")]
		[Address(RVA = "0x35BBF30", Offset = "0x35BAB30", VA = "0x1835BBF30")]
		private void _SetPerspectiveCameraImp()
		{
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C4")]
		[Address(RVA = "0x35B7290", Offset = "0x35B5E90", VA = "0x1835B7290")]
		public void DisableCameraSideBy(bool disable)
		{
		}

		// Token: 0x0600D6C5 RID: 54981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C5")]
		[Address(RVA = "0x35B9EC0", Offset = "0x35B8AC0", VA = "0x1835B9EC0")]
		public void SetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
		}

		// Token: 0x0600D6C6 RID: 54982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D6C6")]
		[Address(RVA = "0x35B8BC0", Offset = "0x35B77C0", VA = "0x1835B8BC0")]
		public Tween MoveCameraDirectly(Vector3 cameraPos, bool tween = true)
		{
			return null;
		}

		// Token: 0x0600D6C7 RID: 54983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C7")]
		[Address(RVA = "0x35B9C30", Offset = "0x35B8830", VA = "0x1835B9C30")]
		public void SetCameraDefaultView(CameraViewLevel cameraView)
		{
		}

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C8")]
		[Address(RVA = "0x35B9AC0", Offset = "0x35B86C0", VA = "0x1835B9AC0")]
		public void SetCameraDefaultView(Vector3 pos)
		{
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6C9")]
		[Address(RVA = "0x35B83A0", Offset = "0x35B6FA0", VA = "0x1835B83A0")]
		public void InitCameraDefaultView()
		{
		}

		// Token: 0x0600D6CA RID: 54986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6CA")]
		[Address(RVA = "0x35B9690", Offset = "0x35B8290", VA = "0x1835B9690")]
		public void ResetCameraPosition(bool tween = true)
		{
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6CB")]
		[Address(RVA = "0x35BA410", Offset = "0x35B9010", VA = "0x1835BA410")]
		public void ShakeCamera(float duration, Vector3 strength, int vibrato, float randomness)
		{
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6CC")]
		[Address(RVA = "0x35B9160", Offset = "0x35B7D60", VA = "0x1835B9160")]
		public void PutDown(Transform ts)
		{
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6CD")]
		[Address(RVA = "0x35B9930", Offset = "0x35B8530", VA = "0x1835B9930")]
		public void ResetFocus(bool tween = true)
		{
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6CE")]
		[Address(RVA = "0x35B7A20", Offset = "0x35B6620", VA = "0x1835B7A20")]
		public void Focus(Transform focusTo, bool tween = true)
		{
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6CF")]
		[Address(RVA = "0x35B7C80", Offset = "0x35B6880", VA = "0x1835B7C80")]
		public void Focus(Transform focusTo, float ratio, bool tween = true)
		{
		}

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D0")]
		[Address(RVA = "0x35B7F60", Offset = "0x35B6B60", VA = "0x1835B7F60")]
		public void Focus(Vector3 pos, float scale, float moveTime, bool tween = true, Ease scaleEase = Ease.Unset, Ease moveEase = Ease.Unset)
		{
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D1")]
		[Address(RVA = "0x35B7920", Offset = "0x35B6520", VA = "0x1835B7920")]
		public void FocusFree(Vector3 pos, float scale, float moveTime, bool tween = true, Ease scaleEase = Ease.Unset, Ease moveEase = Ease.Unset)
		{
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D2")]
		[Address(RVA = "0x35B99B0", Offset = "0x35B85B0", VA = "0x1835B99B0")]
		public void ScaleOn(float value, float time = 0.2f, Ease scaleEase = Ease.Unset, bool tween = true)
		{
		}

		// Token: 0x0600D6D3 RID: 54995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D3")]
		[Address(RVA = "0x35B9710", Offset = "0x35B8310", VA = "0x1835B9710")]
		public void ResetFocusAndScale(float time = 0.2f, Ease scaleEase = Ease.Unset, Ease moveEase = Ease.Unset)
		{
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D4")]
		[Address(RVA = "0x35BB690", Offset = "0x35BA290", VA = "0x1835BB690")]
		private void _FocusInternal(Vector3 pos, bool tween = true)
		{
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D5")]
		[Address(RVA = "0x35BB7A0", Offset = "0x35BA3A0", VA = "0x1835BB7A0")]
		private void _FocusInternal(Vector3 pos, float scale, float moveTime, bool tween = true, Ease scaleEase = Ease.Unset, Ease moveEase = Ease.Unset)
		{
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x0004DA18 File Offset: 0x0004BC18
		[Token(Token = "0x600D6D6")]
		[Address(RVA = "0x35B8870", Offset = "0x35B7470", VA = "0x1835B8870")]
		public bool IsValidPut(int touchId)
		{
			return default(bool);
		}

		// Token: 0x0600D6D7 RID: 54999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D7")]
		[Address(RVA = "0x35B7750", Offset = "0x35B6350", VA = "0x1835B7750")]
		public void FaceToCamera(Transform obj)
		{
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6D8")]
		[Address(RVA = "0x35B7510", Offset = "0x35B6110", VA = "0x1835B7510")]
		public void FaceToCameraOnlyX(Transform obj)
		{
		}

		// Token: 0x0600D6D9 RID: 55001 RVA: 0x0004DA30 File Offset: 0x0004BC30
		[Token(Token = "0x600D6D9")]
		[Address(RVA = "0x35BAF00", Offset = "0x35B9B00", VA = "0x1835BAF00")]
		public Vector2 WorldToViewportDirectionV2(Vector3 origin, Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x0600D6DA RID: 55002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6DA")]
		[Address(RVA = "0x35BB140", Offset = "0x35B9D40", VA = "0x1835BB140")]
		private void _DoAdaptCameraPosition()
		{
		}

		// Token: 0x0600D6DB RID: 55003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6DB")]
		[Address(RVA = "0x35BB490", Offset = "0x35BA090", VA = "0x1835BB490")]
		private void _DoAdaptDefaultCameraPosition()
		{
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x0004DA48 File Offset: 0x0004BC48
		[Token(Token = "0x600D6DC")]
		[Address(RVA = "0x35B8280", Offset = "0x35B6E80", VA = "0x1835B8280")]
		public Vector3 GetCameraPos()
		{
			return default(Vector3);
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x0004DA60 File Offset: 0x0004BC60
		[Token(Token = "0x600D6DD")]
		[Address(RVA = "0x35B8320", Offset = "0x35B6F20", VA = "0x1835B8320")]
		public float GetCameraScale()
		{
			return 0f;
		}

		// Token: 0x0600D6DE RID: 55006 RVA: 0x0004DA78 File Offset: 0x0004BC78
		[Token(Token = "0x600D6DE")]
		[Address(RVA = "0x35B81F0", Offset = "0x35B6DF0", VA = "0x1835B81F0")]
		public float GetCameraHeight()
		{
			return 0f;
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6DF")]
		[Address(RVA = "0x35BAA50", Offset = "0x35B9650", VA = "0x1835BAA50")]
		public void UpdateCameraControllerPos(Vector3 pos)
		{
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E0")]
		[Address(RVA = "0x35BAB30", Offset = "0x35B9730", VA = "0x1835BAB30")]
		public void UpdateCameraControllerScale(float scale)
		{
		}

		// Token: 0x0600D6E1 RID: 55009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E1")]
		[Address(RVA = "0x35B8E90", Offset = "0x35B7A90", VA = "0x1835B8E90")]
		public void ParseCameraBasic(Blackboard blackboard)
		{
		}

		// Token: 0x0600D6E2 RID: 55010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E2")]
		[Address(RVA = "0x35B7330", Offset = "0x35B5F30", VA = "0x1835B7330")]
		public void DoSetCameraStartPos(Vector2 startPos)
		{
		}

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x0004DA90 File Offset: 0x0004BC90
		[Token(Token = "0x600D6E3")]
		[Address(RVA = "0x35BAC30", Offset = "0x35B9830", VA = "0x1835BAC30")]
		public bool UpdateLayerCameraOrigins(PlayerSide playerSide)
		{
			return default(bool);
		}

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E4")]
		[Address(RVA = "0x35BA7A0", Offset = "0x35B93A0", VA = "0x1835BA7A0")]
		public void UpdateAudioListener()
		{
		}

		// Token: 0x0600D6E5 RID: 55013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E5")]
		[Address(RVA = "0x35B7850", Offset = "0x35B6450", VA = "0x1835B7850")]
		public void FinishTweenIfNot()
		{
		}

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E6")]
		[Address(RVA = "0x35BC690", Offset = "0x35BB290", VA = "0x1835BC690")]
		private void _TryCreatePlugin()
		{
		}

		// Token: 0x0600D6E7 RID: 55015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E7")]
		[Address(RVA = "0x35BBFB0", Offset = "0x35BABB0", VA = "0x1835BBFB0")]
		private void _TryCreatePluginByActivity()
		{
		}

		// Token: 0x0600D6E8 RID: 55016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E8")]
		[Address(RVA = "0x35BC2C0", Offset = "0x35BAEC0", VA = "0x1835BC2C0")]
		private void _TryCreatePluginByLevelData()
		{
		}

		// Token: 0x0600D6E9 RID: 55017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6E9")]
		[Address(RVA = "0x35BCB80", Offset = "0x35BB780", VA = "0x1835BCB80")]
		private void _UpdateTransparencySortMode()
		{
		}

		// Token: 0x0600D6EA RID: 55018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6EA")]
		[Address(RVA = "0x35B92E0", Offset = "0x35B7EE0", VA = "0x1835B92E0")]
		public void ReplaceCamera(Camera newCamera)
		{
		}

		// Token: 0x0600D6EB RID: 55019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6EB")]
		[Address(RVA = "0x35B7180", Offset = "0x35B5D80", VA = "0x1835B7180", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x0600D6EC RID: 55020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6EC")]
		[Address(RVA = "0x35BA510", Offset = "0x35B9110", VA = "0x1835BA510")]
		private void Start()
		{
		}

		// Token: 0x0600D6ED RID: 55021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6ED")]
		[Address(RVA = "0x35BAEA0", Offset = "0x35B9AA0", VA = "0x1835BAEA0")]
		public void Update()
		{
		}

		// Token: 0x0600D6EE RID: 55022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6EE")]
		[Address(RVA = "0x35B8D60", Offset = "0x35B7960", VA = "0x1835B8D60", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600D6EF RID: 55023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6EF")]
		[Address(RVA = "0x35B8E10", Offset = "0x35B7A10", VA = "0x1835B8E10", Slot = "8")]
		public void OnSafeRectUpdated(SafeRect safeRect)
		{
		}

		// Token: 0x0600D6F0 RID: 55024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6F0")]
		[Address(RVA = "0x35BBE60", Offset = "0x35BAA60", VA = "0x1835BBE60")]
		private void _InitPostProcessLayer()
		{
		}

		// Token: 0x0600D6F1 RID: 55025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6F1")]
		[Address(RVA = "0x35B8600", Offset = "0x35B7200", VA = "0x1835B8600")]
		public void InitPostProcessAA()
		{
		}

		// Token: 0x0600D6F2 RID: 55026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6F2")]
		[Address(RVA = "0x35BA370", Offset = "0x35B8F70", VA = "0x1835BA370")]
		public void SetSMAA(SubpixelMorphologicalAntialiasing.Quality quality)
		{
		}

		// Token: 0x0600D6F3 RID: 55027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6F3")]
		[Address(RVA = "0x35BC870", Offset = "0x35BB470", VA = "0x1835BC870")]
		private void _UpdateFrustumPlanesIfNeeded()
		{
		}

		// Token: 0x0600D6F4 RID: 55028 RVA: 0x0004DAA8 File Offset: 0x0004BCA8
		[Token(Token = "0x600D6F4")]
		[Address(RVA = "0x35B89F0", Offset = "0x35B75F0", VA = "0x1835B89F0")]
		public bool IsVisible(Vector3 center, float radius)
		{
			return default(bool);
		}

		// Token: 0x0600D6F5 RID: 55029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6F5")]
		[Address(RVA = "0x35BBCF0", Offset = "0x35BA8F0", VA = "0x1835BBCF0")]
		private void _InitCameraRTScaler()
		{
		}

		// Token: 0x0600D6F6 RID: 55030 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		[Token(Token = "0x600D6F6")]
		[Address(RVA = "0x35BCC40", Offset = "0x35BB840", VA = "0x1835BCC40")]
		private bool _ValidateBattleCameraRTDownScale()
		{
			return default(bool);
		}

		// Token: 0x0600D6F7 RID: 55031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D6F7")]
		[Address(RVA = "0x35BCCF0", Offset = "0x35BB8F0", VA = "0x1835BCCF0")]
		public CameraController()
		{
		}

		// Token: 0x0400E6D7 RID: 59095
		[Token(Token = "0x400E6D7")]
		private const string PERSPECTIVE_UI_CAMERA_NAME = "PerspectiveUICamera";

		// Token: 0x0400E6D8 RID: 59096
		[Token(Token = "0x400E6D8")]
		private const Ease EASE_TYPE_SCALE = Ease.InOutQuad;

		// Token: 0x0400E6D9 RID: 59097
		[Token(Token = "0x400E6D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Cameras")]
		private Camera _camera;

		// Token: 0x0400E6DA RID: 59098
		[Token(Token = "0x400E6DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Cameras")]
		private Camera _fakeCamera;

		// Token: 0x0400E6DB RID: 59099
		[Token(Token = "0x400E6DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Cameras")]
		private Camera _uiPerspectiveCamera;

		// Token: 0x0400E6DC RID: 59100
		[Token(Token = "0x400E6DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _offset;

		// Token: 0x0400E6DD RID: 59101
		[Token(Token = "0x400E6DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _moveTime;

		// Token: 0x0400E6DE RID: 59102
		[Token(Token = "0x400E6DE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x0400E6DF RID: 59103
		[Token(Token = "0x400E6DF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Collection(typeof(CameraController.CameraPosition), Sortable = false)]
		private Transform[] _placeholders;

		// Token: 0x0400E6E0 RID: 59104
		[Token(Token = "0x400E6E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Adapter")]
		private Vector2 _fromResolution;

		// Token: 0x0400E6E1 RID: 59105
		[Token(Token = "0x400E6E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Adapter")]
		private Vector2 _toResolution;

		// Token: 0x0400E6E2 RID: 59106
		[Token(Token = "0x400E6E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Adapter")]
		private Vector3 _fromLocalPosition;

		// Token: 0x0400E6E3 RID: 59107
		[Token(Token = "0x400E6E3")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Group("Adapter")]
		private Vector3 _toLocalPosition;

		// Token: 0x0400E6E4 RID: 59108
		[Token(Token = "0x400E6E4")]
		[FieldOffset(Offset = "0x70")]
		[Group("Layer", 2)]
		[ReadOnly]
		[Inspect]
		private MapLayer m_originalLayer;

		// Token: 0x0400E6E5 RID: 59109
		[Token(Token = "0x400E6E5")]
		[FieldOffset(Offset = "0x78")]
		private PostProcessLayer m_postProcessLayer;

		// Token: 0x0400E6E6 RID: 59110
		[Token(Token = "0x400E6E6")]
		[FieldOffset(Offset = "0x80")]
		private AntialiasingProfile m_aaProfile;

		// Token: 0x0400E6E7 RID: 59111
		[Token(Token = "0x400E6E7")]
		[FieldOffset(Offset = "0x88")]
		private bool m_cameraMoveDirectlyDisableState;

		// Token: 0x0400E6E9 RID: 59113
		[Token(Token = "0x400E6E9")]
		[FieldOffset(Offset = "0x90")]
		[Inspect]
		[Group("Layer")]
		private readonly List<Vector3> m_layerOrigins;

		// Token: 0x0400E6EA RID: 59114
		[Token(Token = "0x400E6EA")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 m_originPos;

		// Token: 0x0400E6EB RID: 59115
		[Token(Token = "0x400E6EB")]
		[FieldOffset(Offset = "0xA4")]
		private float? m_overrideScale;

		// Token: 0x0400E6EC RID: 59116
		[Token(Token = "0x400E6EC")]
		[FieldOffset(Offset = "0xAC")]
		private CameraController.CameraPosition m_cameraPosition;

		// Token: 0x0400E6ED RID: 59117
		[Token(Token = "0x400E6ED")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_moveTween;

		// Token: 0x0400E6EE RID: 59118
		[Token(Token = "0x400E6EE")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_scaleTween;

		// Token: 0x0400E6EF RID: 59119
		[Token(Token = "0x400E6EF")]
		[FieldOffset(Offset = "0xC0")]
		private int m_isTweening;

		// Token: 0x0400E6F0 RID: 59120
		[Token(Token = "0x400E6F0")]
		[FieldOffset(Offset = "0xC4")]
		private int m_isPerspectiveCameraOn;

		// Token: 0x0400E6F1 RID: 59121
		[Token(Token = "0x400E6F1")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_disableCameraSideBy;

		// Token: 0x0400E6F3 RID: 59123
		[Token(Token = "0x400E6F3")]
		[FieldOffset(Offset = "0xD8")]
		private Plane[] m_planes;

		// Token: 0x0400E6F4 RID: 59124
		[Token(Token = "0x400E6F4")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 m_cacheCameraPos;

		// Token: 0x0400E6F5 RID: 59125
		[Token(Token = "0x400E6F5")]
		[FieldOffset(Offset = "0xEC")]
		private Quaternion m_cacheCameraRotation;

		// Token: 0x0400E6F6 RID: 59126
		[Token(Token = "0x400E6F6")]
		[FieldOffset(Offset = "0xFC")]
		private float m_cacheFov;

		// Token: 0x0400E6F7 RID: 59127
		[Token(Token = "0x400E6F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasPPLayer;

		// Token: 0x0400E6F8 RID: 59128
		[Token(Token = "0x400E6F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentLayer;

		// Token: 0x0400E6F9 RID: 59129
		[Token(Token = "0x400E6F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_currentLayer;

		// Token: 0x0400E6FA RID: 59130
		[Token(Token = "0x400E6FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_originPos;

		// Token: 0x0400E6FB RID: 59131
		[Token(Token = "0x400E6FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_originPos;

		// Token: 0x0400E6FC RID: 59132
		[Token(Token = "0x400E6FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_nextLayer;

		// Token: 0x0400E6FD RID: 59133
		[Token(Token = "0x400E6FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isTweening;

		// Token: 0x0400E6FE RID: 59134
		[Token(Token = "0x400E6FE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isMoving;

		// Token: 0x0400E6FF RID: 59135
		[Token(Token = "0x400E6FF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isScaling;

		// Token: 0x0400E700 RID: 59136
		[Token(Token = "0x400E700")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_cameraPosition;

		// Token: 0x0400E701 RID: 59137
		[Token(Token = "0x400E701")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_camera;

		// Token: 0x0400E702 RID: 59138
		[Token(Token = "0x400E702")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_uiPerspectiveCamera;

		// Token: 0x0400E703 RID: 59139
		[Token(Token = "0x400E703")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0400E704 RID: 59140
		[Token(Token = "0x400E704")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_plugin;

		// Token: 0x0400E705 RID: 59141
		[Token(Token = "0x400E705")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x0400E706 RID: 59142
		[Token(Token = "0x400E706")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_offsetTransform;

		// Token: 0x0400E707 RID: 59143
		[Token(Token = "0x400E707")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ResetAll;

		// Token: 0x0400E708 RID: 59144
		[Token(Token = "0x400E708")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SetCameraMoveDirectlyDisableState;

		// Token: 0x0400E709 RID: 59145
		[Token(Token = "0x400E709")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetPerspectiveCameraOn;

		// Token: 0x0400E70A RID: 59146
		[Token(Token = "0x400E70A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetPerspectiveCameraImp;

		// Token: 0x0400E70B RID: 59147
		[Token(Token = "0x400E70B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_DisableCameraSideBy;

		// Token: 0x0400E70C RID: 59148
		[Token(Token = "0x400E70C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetCameraPosition;

		// Token: 0x0400E70D RID: 59149
		[Token(Token = "0x400E70D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_MoveCameraDirectly;

		// Token: 0x0400E70E RID: 59150
		[Token(Token = "0x400E70E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetCameraDefaultView;

		// Token: 0x0400E70F RID: 59151
		[Token(Token = "0x400E70F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix1_SetCameraDefaultView;

		// Token: 0x0400E710 RID: 59152
		[Token(Token = "0x400E710")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_InitCameraDefaultView;

		// Token: 0x0400E711 RID: 59153
		[Token(Token = "0x400E711")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ResetCameraPosition;

		// Token: 0x0400E712 RID: 59154
		[Token(Token = "0x400E712")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ShakeCamera;

		// Token: 0x0400E713 RID: 59155
		[Token(Token = "0x400E713")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_PutDown;

		// Token: 0x0400E714 RID: 59156
		[Token(Token = "0x400E714")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ResetFocus;

		// Token: 0x0400E715 RID: 59157
		[Token(Token = "0x400E715")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_Focus;

		// Token: 0x0400E716 RID: 59158
		[Token(Token = "0x400E716")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix1_Focus;

		// Token: 0x0400E717 RID: 59159
		[Token(Token = "0x400E717")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix2_Focus;

		// Token: 0x0400E718 RID: 59160
		[Token(Token = "0x400E718")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_FocusFree;

		// Token: 0x0400E719 RID: 59161
		[Token(Token = "0x400E719")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ScaleOn;

		// Token: 0x0400E71A RID: 59162
		[Token(Token = "0x400E71A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ResetFocusAndScale;

		// Token: 0x0400E71B RID: 59163
		[Token(Token = "0x400E71B")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__FocusInternal;

		// Token: 0x0400E71C RID: 59164
		[Token(Token = "0x400E71C")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix1__FocusInternal;

		// Token: 0x0400E71D RID: 59165
		[Token(Token = "0x400E71D")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_IsValidPut;

		// Token: 0x0400E71E RID: 59166
		[Token(Token = "0x400E71E")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_FaceToCamera;

		// Token: 0x0400E71F RID: 59167
		[Token(Token = "0x400E71F")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_FaceToCameraOnlyX;

		// Token: 0x0400E720 RID: 59168
		[Token(Token = "0x400E720")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_WorldToViewportDirectionV2;

		// Token: 0x0400E721 RID: 59169
		[Token(Token = "0x400E721")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__DoAdaptCameraPosition;

		// Token: 0x0400E722 RID: 59170
		[Token(Token = "0x400E722")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__DoAdaptDefaultCameraPosition;

		// Token: 0x0400E723 RID: 59171
		[Token(Token = "0x400E723")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_GetCameraPos;

		// Token: 0x0400E724 RID: 59172
		[Token(Token = "0x400E724")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_GetCameraScale;

		// Token: 0x0400E725 RID: 59173
		[Token(Token = "0x400E725")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_GetCameraHeight;

		// Token: 0x0400E726 RID: 59174
		[Token(Token = "0x400E726")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_UpdateCameraControllerPos;

		// Token: 0x0400E727 RID: 59175
		[Token(Token = "0x400E727")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_UpdateCameraControllerScale;

		// Token: 0x0400E728 RID: 59176
		[Token(Token = "0x400E728")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ParseCameraBasic;

		// Token: 0x0400E729 RID: 59177
		[Token(Token = "0x400E729")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_DoSetCameraStartPos;

		// Token: 0x0400E72A RID: 59178
		[Token(Token = "0x400E72A")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_UpdateLayerCameraOrigins;

		// Token: 0x0400E72B RID: 59179
		[Token(Token = "0x400E72B")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UpdateAudioListener;

		// Token: 0x0400E72C RID: 59180
		[Token(Token = "0x400E72C")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_FinishTweenIfNot;

		// Token: 0x0400E72D RID: 59181
		[Token(Token = "0x400E72D")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__TryCreatePlugin;

		// Token: 0x0400E72E RID: 59182
		[Token(Token = "0x400E72E")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__TryCreatePluginByActivity;

		// Token: 0x0400E72F RID: 59183
		[Token(Token = "0x400E72F")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__TryCreatePluginByLevelData;

		// Token: 0x0400E730 RID: 59184
		[Token(Token = "0x400E730")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__UpdateTransparencySortMode;

		// Token: 0x0400E731 RID: 59185
		[Token(Token = "0x400E731")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_ReplaceCamera;

		// Token: 0x0400E732 RID: 59186
		[Token(Token = "0x400E732")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400E733 RID: 59187
		[Token(Token = "0x400E733")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400E734 RID: 59188
		[Token(Token = "0x400E734")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400E735 RID: 59189
		[Token(Token = "0x400E735")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400E736 RID: 59190
		[Token(Token = "0x400E736")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x0400E737 RID: 59191
		[Token(Token = "0x400E737")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__InitPostProcessLayer;

		// Token: 0x0400E738 RID: 59192
		[Token(Token = "0x400E738")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_InitPostProcessAA;

		// Token: 0x0400E739 RID: 59193
		[Token(Token = "0x400E739")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_SetSMAA;

		// Token: 0x0400E73A RID: 59194
		[Token(Token = "0x400E73A")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__UpdateFrustumPlanesIfNeeded;

		// Token: 0x0400E73B RID: 59195
		[Token(Token = "0x400E73B")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_IsVisible;

		// Token: 0x0400E73C RID: 59196
		[Token(Token = "0x400E73C")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__InitCameraRTScaler;

		// Token: 0x0400E73D RID: 59197
		[Token(Token = "0x400E73D")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__ValidateBattleCameraRTDownScale;

		// Token: 0x0400E73E RID: 59198
		[Token(Token = "0x400E73E")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021A5 RID: 8613
		[Token(Token = "0x20021A5")]
		public abstract class Plugin : MonoBehaviour, IHotfixable
		{
			// Token: 0x17001A13 RID: 6675
			// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600D6FB RID: 55035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A13")]
			private protected CameraController controller
			{
				[Token(Token = "0x600D6FA")]
				[Address(RVA = "0x35D8D60", Offset = "0x35D7960", VA = "0x1835D8D60")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600D6FB")]
				[Address(RVA = "0x35D9850", Offset = "0x35D8450", VA = "0x1835D9850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001A14 RID: 6676
			// (get) Token: 0x0600D6FC RID: 55036 RVA: 0x0004DAD8 File Offset: 0x0004BCD8
			[Token(Token = "0x17001A14")]
			private bool controllerNotNull
			{
				[Token(Token = "0x600D6FC")]
				[Address(RVA = "0x35D8C90", Offset = "0x35D7890", VA = "0x1835D8C90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001A15 RID: 6677
			// (get) Token: 0x0600D6FD RID: 55037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A15")]
			protected Camera camera
			{
				[Token(Token = "0x600D6FD")]
				[Address(RVA = "0x35D8BE0", Offset = "0x35D77E0", VA = "0x1835D8BE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A16 RID: 6678
			// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
			// (set) Token: 0x0600D6FF RID: 55039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A16")]
			[Inspect("controllerNotNull")]
			[Group("Layer")]
			protected MapLayer currentLayer
			{
				[Token(Token = "0x600D6FE")]
				[Address(RVA = "0x35D8E90", Offset = "0x35D7A90", VA = "0x1835D8E90")]
				get
				{
					return MapLayer.LAYER_A;
				}
				[Token(Token = "0x600D6FF")]
				[Address(RVA = "0x35D98D0", Offset = "0x35D84D0", VA = "0x1835D98D0")]
				set
				{
				}
			}

			// Token: 0x17001A17 RID: 6679
			// (get) Token: 0x0600D700 RID: 55040 RVA: 0x0004DB08 File Offset: 0x0004BD08
			[Token(Token = "0x17001A17")]
			[Inspect("controllerNotNull")]
			[Group("Layer")]
			protected MapLayer nextLayer
			{
				[Token(Token = "0x600D700")]
				[Address(RVA = "0x35D9300", Offset = "0x35D7F00", VA = "0x1835D9300")]
				get
				{
					return MapLayer.LAYER_A;
				}
			}

			// Token: 0x17001A18 RID: 6680
			// (get) Token: 0x0600D701 RID: 55041 RVA: 0x0004DB20 File Offset: 0x0004BD20
			[Token(Token = "0x17001A18")]
			[Inspect("controllerNotNull")]
			[Group("Layer")]
			protected Vector3 currentLayerOrigin
			{
				[Token(Token = "0x600D701")]
				[Address(RVA = "0x35D8DC0", Offset = "0x35D79C0", VA = "0x1835D8DC0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001A19 RID: 6681
			// (get) Token: 0x0600D702 RID: 55042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A19")]
			[Inspect("controllerNotNull")]
			[Group("Layer")]
			protected List<Vector3> layerOrigins
			{
				[Token(Token = "0x600D702")]
				[Address(RVA = "0x35D91A0", Offset = "0x35D7DA0", VA = "0x1835D91A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A1A RID: 6682
			// (get) Token: 0x0600D703 RID: 55043 RVA: 0x0004DB38 File Offset: 0x0004BD38
			// (set) Token: 0x0600D704 RID: 55044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A1A")]
			[Inspect("controllerNotNull")]
			[Group("Layer")]
			protected Vector3 originPos
			{
				[Token(Token = "0x600D703")]
				[Address(RVA = "0x35D9460", Offset = "0x35D8060", VA = "0x1835D9460")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600D704")]
				[Address(RVA = "0x35D9990", Offset = "0x35D8590", VA = "0x1835D9990")]
				set
				{
				}
			}

			// Token: 0x17001A1B RID: 6683
			// (get) Token: 0x0600D705 RID: 55045 RVA: 0x0004DB50 File Offset: 0x0004BD50
			[Token(Token = "0x17001A1B")]
			protected Vector3 fromResolution
			{
				[Token(Token = "0x600D705")]
				[Address(RVA = "0x35D90C0", Offset = "0x35D7CC0", VA = "0x1835D90C0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001A1C RID: 6684
			// (get) Token: 0x0600D706 RID: 55046 RVA: 0x0004DB68 File Offset: 0x0004BD68
			[Token(Token = "0x17001A1C")]
			protected Vector3 toResolution
			{
				[Token(Token = "0x600D706")]
				[Address(RVA = "0x35D96B0", Offset = "0x35D82B0", VA = "0x1835D96B0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001A1D RID: 6685
			// (get) Token: 0x0600D707 RID: 55047 RVA: 0x0004DB80 File Offset: 0x0004BD80
			[Token(Token = "0x17001A1D")]
			protected Vector3 fromLocalPosition
			{
				[Token(Token = "0x600D707")]
				[Address(RVA = "0x35D8FF0", Offset = "0x35D7BF0", VA = "0x1835D8FF0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001A1E RID: 6686
			// (get) Token: 0x0600D708 RID: 55048 RVA: 0x0004DB98 File Offset: 0x0004BD98
			[Token(Token = "0x17001A1E")]
			protected Vector3 toLocalPosition
			{
				[Token(Token = "0x600D708")]
				[Address(RVA = "0x35D95E0", Offset = "0x35D81E0", VA = "0x1835D95E0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17001A1F RID: 6687
			// (get) Token: 0x0600D709 RID: 55049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A1F")]
			protected Transform[] placeholders
			{
				[Token(Token = "0x600D709")]
				[Address(RVA = "0x35D9530", Offset = "0x35D8130", VA = "0x1835D9530")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A20 RID: 6688
			// (get) Token: 0x0600D70A RID: 55050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001A20")]
			protected Transform offset
			{
				[Token(Token = "0x600D70A")]
				[Address(RVA = "0x35D93B0", Offset = "0x35D7FB0", VA = "0x1835D93B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001A21 RID: 6689
			// (get) Token: 0x0600D70B RID: 55051 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
			[Token(Token = "0x17001A21")]
			protected float moveTime
			{
				[Token(Token = "0x600D70B")]
				[Address(RVA = "0x35D9250", Offset = "0x35D7E50", VA = "0x1835D9250")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17001A22 RID: 6690
			// (get) Token: 0x0600D70C RID: 55052 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
			[Token(Token = "0x17001A22")]
			protected Ease easeType
			{
				[Token(Token = "0x600D70C")]
				[Address(RVA = "0x35D8F40", Offset = "0x35D7B40", VA = "0x1835D8F40")]
				get
				{
					return Ease.Unset;
				}
			}

			// Token: 0x17001A23 RID: 6691
			// (get) Token: 0x0600D70E RID: 55054 RVA: 0x0004DBE0 File Offset: 0x0004BDE0
			// (set) Token: 0x0600D70D RID: 55053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001A23")]
			protected CameraController.CameraPosition cameraPosition
			{
				[Token(Token = "0x600D70E")]
				[Address(RVA = "0x35D8B30", Offset = "0x35D7730", VA = "0x1835D8B30")]
				get
				{
					return CameraController.CameraPosition.DEFAULT;
				}
				[Token(Token = "0x600D70D")]
				[Address(RVA = "0x35D9790", Offset = "0x35D8390", VA = "0x1835D9790")]
				set
				{
				}
			}

			// Token: 0x17001A24 RID: 6692
			// (get) Token: 0x0600D70F RID: 55055 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
			[Token(Token = "0x17001A24")]
			public virtual Vector2 audioVolumeSyncCameraPosRange
			{
				[Token(Token = "0x600D70F")]
				[Address(RVA = "0x35D51E0", Offset = "0x35D3DE0", VA = "0x1835D51E0", Slot = "4")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x0600D710 RID: 55056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D710")]
			[Address(RVA = "0x35D8990", Offset = "0x35D7590", VA = "0x1835D8990", Slot = "5")]
			public virtual void OnCreate(CameraController controller)
			{
			}

			// Token: 0x0600D711 RID: 55057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D711")]
			[Address(RVA = "0x35D50B0", Offset = "0x35D3CB0", VA = "0x1835D50B0", Slot = "6")]
			public virtual void DoAdaptCameraPosition()
			{
			}

			// Token: 0x0600D712 RID: 55058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D712")]
			[Address(RVA = "0x35D88F0", Offset = "0x35D74F0", VA = "0x1835D88F0", Slot = "7")]
			public virtual Tween DoMoveCameraDirectly(Vector3 targetPos, bool tween = true)
			{
				return null;
			}

			// Token: 0x0600D713 RID: 55059 RVA: 0x0004DC10 File Offset: 0x0004BE10
			[Token(Token = "0x600D713")]
			[Address(RVA = "0x35D4F70", Offset = "0x35D3B70", VA = "0x1835D4F70", Slot = "8")]
			public virtual Vector3 CalculateCameraFocusPos(Vector3 targetPos)
			{
				return default(Vector3);
			}

			// Token: 0x0600D714 RID: 55060 RVA: 0x0004DC28 File Offset: 0x0004BE28
			[Token(Token = "0x600D714")]
			[Address(RVA = "0x35D5010", Offset = "0x35D3C10", VA = "0x1835D5010", Slot = "9")]
			public virtual Vector3 CalculateCameraOffset(Vector3 originPos)
			{
				return default(Vector3);
			}

			// Token: 0x0600D715 RID: 55061 RVA: 0x0004DC40 File Offset: 0x0004BE40
			[Token(Token = "0x600D715")]
			[Address(RVA = "0x35D8A40", Offset = "0x35D7640", VA = "0x1835D8A40", Slot = "10")]
			public virtual bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
			{
				return default(bool);
			}

			// Token: 0x0600D716 RID: 55062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D716")]
			[Address(RVA = "0x35D5180", Offset = "0x35D3D80", VA = "0x1835D5180", Slot = "11")]
			public virtual void PutDown(Transform ts)
			{
			}

			// Token: 0x0600D717 RID: 55063 RVA: 0x0004DC58 File Offset: 0x0004BE58
			[Token(Token = "0x600D717")]
			[Address(RVA = "0x35D5110", Offset = "0x35D3D10", VA = "0x1835D5110", Slot = "12")]
			public virtual bool IsValidPut(int touchId)
			{
				return default(bool);
			}

			// Token: 0x0600D718 RID: 55064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D718")]
			[Address(RVA = "0x35D8AD0", Offset = "0x35D76D0", VA = "0x1835D8AD0")]
			protected Plugin()
			{
			}

			// Token: 0x0400E740 RID: 59200
			[Token(Token = "0x400E740")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_controller;

			// Token: 0x0400E741 RID: 59201
			[Token(Token = "0x400E741")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_controller;

			// Token: 0x0400E742 RID: 59202
			[Token(Token = "0x400E742")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_controllerNotNull;

			// Token: 0x0400E743 RID: 59203
			[Token(Token = "0x400E743")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_camera;

			// Token: 0x0400E744 RID: 59204
			[Token(Token = "0x400E744")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_currentLayer;

			// Token: 0x0400E745 RID: 59205
			[Token(Token = "0x400E745")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_currentLayer;

			// Token: 0x0400E746 RID: 59206
			[Token(Token = "0x400E746")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_nextLayer;

			// Token: 0x0400E747 RID: 59207
			[Token(Token = "0x400E747")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_currentLayerOrigin;

			// Token: 0x0400E748 RID: 59208
			[Token(Token = "0x400E748")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_layerOrigins;

			// Token: 0x0400E749 RID: 59209
			[Token(Token = "0x400E749")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_originPos;

			// Token: 0x0400E74A RID: 59210
			[Token(Token = "0x400E74A")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_originPos;

			// Token: 0x0400E74B RID: 59211
			[Token(Token = "0x400E74B")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_fromResolution;

			// Token: 0x0400E74C RID: 59212
			[Token(Token = "0x400E74C")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_toResolution;

			// Token: 0x0400E74D RID: 59213
			[Token(Token = "0x400E74D")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_fromLocalPosition;

			// Token: 0x0400E74E RID: 59214
			[Token(Token = "0x400E74E")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_toLocalPosition;

			// Token: 0x0400E74F RID: 59215
			[Token(Token = "0x400E74F")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_get_placeholders;

			// Token: 0x0400E750 RID: 59216
			[Token(Token = "0x400E750")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_get_offset;

			// Token: 0x0400E751 RID: 59217
			[Token(Token = "0x400E751")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_get_moveTime;

			// Token: 0x0400E752 RID: 59218
			[Token(Token = "0x400E752")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_get_easeType;

			// Token: 0x0400E753 RID: 59219
			[Token(Token = "0x400E753")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_set_cameraPosition;

			// Token: 0x0400E754 RID: 59220
			[Token(Token = "0x400E754")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_get_cameraPosition;

			// Token: 0x0400E755 RID: 59221
			[Token(Token = "0x400E755")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_get_audioVolumeSyncCameraPosRange;

			// Token: 0x0400E756 RID: 59222
			[Token(Token = "0x400E756")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_OnCreate;

			// Token: 0x0400E757 RID: 59223
			[Token(Token = "0x400E757")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_DoAdaptCameraPosition;

			// Token: 0x0400E758 RID: 59224
			[Token(Token = "0x400E758")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

			// Token: 0x0400E759 RID: 59225
			[Token(Token = "0x400E759")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

			// Token: 0x0400E75A RID: 59226
			[Token(Token = "0x400E75A")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_CalculateCameraOffset;

			// Token: 0x0400E75B RID: 59227
			[Token(Token = "0x400E75B")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_TrySetCameraPosition;

			// Token: 0x0400E75C RID: 59228
			[Token(Token = "0x400E75C")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_PutDown;

			// Token: 0x0400E75D RID: 59229
			[Token(Token = "0x400E75D")]
			[FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_IsValidPut;

			// Token: 0x0400E75E RID: 59230
			[Token(Token = "0x400E75E")]
			[FieldOffset(Offset = "0xF0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020021A6 RID: 8614
		[Token(Token = "0x20021A6")]
		public enum CameraPosition
		{
			// Token: 0x0400E760 RID: 59232
			[Token(Token = "0x400E760")]
			DEFAULT,
			// Token: 0x0400E761 RID: 59233
			[Token(Token = "0x400E761")]
			SIDE_BY
		}

		// Token: 0x020021A7 RID: 8615
		[Token(Token = "0x20021A7")]
		public enum PostprocessMask : byte
		{
			// Token: 0x0400E763 RID: 59235
			[Token(Token = "0x400E763")]
			NONE,
			// Token: 0x0400E764 RID: 59236
			[Token(Token = "0x400E764")]
			COLOR_GRADING
		}

		// Token: 0x020021A8 RID: 8616
		[Token(Token = "0x20021A8")]
		public enum PerpectiveCameraMask
		{
			// Token: 0x0400E766 RID: 59238
			[Token(Token = "0x400E766")]
			BATTLE,
			// Token: 0x0400E767 RID: 59239
			[Token(Token = "0x400E767")]
			UI_PAGE
		}
	}
}
