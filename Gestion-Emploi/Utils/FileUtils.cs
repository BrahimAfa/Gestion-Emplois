using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GestionEmploi.Utils
{
  public static class FileUtils
  {
    public static Config LoadJson()
    {
      string file = HttpContext.Current.Server.MapPath("~/Utils/GestionEmploisConfig.json");
      using (StreamReader r = new StreamReader(file))
      {
        string json = r.ReadToEnd();
        Config config = JsonConvert.DeserializeObject<Config>(json);
        return config;
      }
    }

  }
}