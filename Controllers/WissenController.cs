using Microsoft.AspNetCore.Mvc;

public class WissenController:Controller{
    public IActionResult Index(){

        IndexViewModel model = new IndexViewModel() {ImageUrl="https://picsum.photos/200/300"};
        return View(model);
        //Model, View'a dinamik veri göndermek için kullanılır. 
        //Eğer View dosyasında bir görselin URL'sini veya başka bir dinamik içeriği göstermek istiyorsanız, 
        //bu tür verileri bir model aracılığıyla göndermeniz gerekir.
    }
}