using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpDX;
using SharpDX.Windows;
using SharpDX.DXGI;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;

using Device = SharpDX.Direct3D11.Device;
using System.Drawing;
using SharpDX.DXGI;
using D3D11 = SharpDX.Direct3D11;

namespace windowsAppGame
{
    class App : IDisposable
    {
        private RenderForm renderForm;

        private const int Width = 1280;
        private const int Height = 720;

        private D3D11.Device d3dDevice;
        private D3D11.DeviceContext d3dDeviceContext;
        private SwapChain swapChain;

        private D3D11.RenderTargetView renderTargetView;

        public App()
        {
            renderForm = new RenderForm("My first SharpDX game");
            renderForm.ClientSize = new Size(Width, Height);
            renderForm.AllowUserResizing = false;
        }

        public void Run()
        {
            RenderLoop.Run(renderForm, RenderCallback);
        }

        private void RenderCallback()
        {

        }
        /*
        [STAThread]
        public static void Main()
        {

            using (App application = new App())
            {
                application.Run();
            }

        }
        */

        public void Dispose()
        {
            renderForm.Dispose();
        }
        private void InitializeDeviceResources()
        {
            ModeDescription backBufferDesc = new ModeDescription(Width, Height, new Rational(60, 1), Format.R8G8B8A8_UNorm);

            SwapChainDescription swapChainDesc = new SwapChainDescription()
            {
                ModeDescription = backBufferDesc,
                SampleDescription = new SampleDescription(1, 0),
                Usage = Usage.RenderTargetOutput,
                BufferCount = 1,
                OutputHandle = renderForm.Handle,
                IsWindowed = true
            };

            D3D11.Device.CreateWithSwapChain(DriverType.Hardware, D3D11.DeviceCreationFlags.None, swapChainDesc, out d3dDevice, out swapChain);
            d3dDeviceContext = d3dDevice.ImmediateContext;



        }
    }
}
